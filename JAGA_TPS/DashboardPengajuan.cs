using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGA_TPS
{
    public partial class DashboardPengajuan : Form
    {

        private TPSModel? _tpsTerpilih;
        private Form? _formDashboardAsal;

        public DashboardPengajuan()
        {
            InitializeComponent();
            // Simpan objek yang dikirim

        }

        // Constructor dengan parameter (opsional, jika suatu saat dipanggil langsung dengan TPSModel)
        //public DashboardPengajuan(TPSModel tpsObjek) : this()
        //{
        //    MuatDataTps(tpsObjek);
        //}

        public void MuatDataTps(TPSModel tps, Form? formAsal = null)
        {
            if (tps == null) return;

            _tpsTerpilih = tps;
            _formDashboardAsal = formAsal;

            // Menentukan status TPS
            if (tps.Volume <= 40)
            {
                lblStatusTPS.Text = "Aman";
                lblStatusTPS.BackColor = Color.LightGreen;
                lblStatusTPS.ForeColor = Color.DarkGreen;
                //lblVolume.ForeColor = Color.DarkGreen;
                flyStatus.BackColor = Color.LightGreen;
            }
            else if (tps.Volume <= 75)
            {
                lblStatusTPS.Text = "Normal";
                lblStatusTPS.BackColor = Color.LightGoldenrodYellow;
                lblStatusTPS.ForeColor = Color.DarkGoldenrod;
                //lblVolume.ForeColor = Color.DarkGoldenrod;
                flyStatus.BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                lblStatusTPS.Text = "Kritis";
                lblStatusTPS.BackColor = Color.MistyRose;
                lblStatusTPS.ForeColor = Color.Red;
                //lblVolume.ForeColor = Color.Red;
                flyStatus.BackColor = Color.MistyRose;
            }

            // Sesuaikan nama Label / TextBox di bawah ini dengan nama kontrol di DashboardPengajuan.Designer.cs
            //lblIdTPS.Text = tps.Id;
            //lblStatusTPS.Text = statusTps;
            lblNamaTPS.Text = tps.NamaTPS;
            lblLokasiTPS.Text = tps.Lokasi;
            lblJadwal.Text = tps.JadwalRutin;
        }

       
        private void btnAjukan_Click(object sender, EventArgs e)
        {
            if (_tpsTerpilih == null) return;

            // 1. Ubah status TPS menjadi "Menunggu"
            _tpsTerpilih.Status = "Menunggu";

            MessageBox.Show(
                "Pengajuan pengangkutan berhasil dikirim. Status TPS kini Menunggu.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // 2. Kembali ke DashboardPengisianHarian dan refresh daftar TPS
            if (_formDashboardAsal is DashboardPengisianHarian dashboardHarian)
            {
                dashboardHarian.RefreshDaftarTPS();
                dashboardHarian.Show();
            }
            else
            {
                var dashboardBaru = new DashboardPengisianHarian();
                dashboardBaru.Show();
            }

            // 3. Tutup form pengajuan
            this.Close();
        }
    }
}
