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
        public DashboardPengajuan()
        {
            InitializeComponent();
            // Simpan objek yang dikirim

        }

        // Constructor dengan parameter (opsional, jika suatu saat dipanggil langsung dengan TPSModel)
        public DashboardPengajuan(TPSModel tpsObjek) : this()
        {
            MuatDataTps(tpsObjek);
        }

        public void MuatDataTps(TPSModel tps)
        {
            if (tps == null) return;

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

        private void DashboardPengajuan_Load(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
