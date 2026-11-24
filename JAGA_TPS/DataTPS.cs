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
    public partial class DataTPS : UserControl
    {

        public event EventHandler<TPSModel>? AjukanClicked;
        public TPSModel? DataTps { get; private set; }

        public DataTPS()
        {
            InitializeComponent();
            
        }

        public void TampilkanData(TPSModel tps)
        {
            DataTps = tps;
            lblNamaTPS.Text = tps.NamaTPS;
            lblLokasiTPS.Text = tps.Lokasi;

            // Menampilkan persentase
            lblVolume.Text = tps.Volume + "%";

            lblJadwal.Text = "" + tps.JadwalRutin;

            // Menentukan status TPS
            if (tps.Status == "Menunggu")
            {
                lblStatus.Text = "Menunggu";
                lblStatus.BackColor = Color.LightSkyBlue;
                lblStatus.ForeColor = Color.Navy;
                flyStatus.BackColor = Color.LightSkyBlue;
                btnAjukanPengangkutan.Enabled = false;
                btnAjukanPengangkutan.Text = "Menunggu...";
            }
            else if (tps.Volume <= 40)
            {
                lblStatus.Text = "Aman";
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.ForeColor = Color.DarkGreen;
                lblVolume.ForeColor = Color.DarkGreen;
                flyStatus.BackColor = Color.LightGreen;
            }
            else if (tps.Volume <= 75)
            {
                lblStatus.Text = "Normal";
                lblStatus.BackColor = Color.LightGoldenrodYellow;
                lblStatus.ForeColor = Color.DarkGoldenrod;
                lblVolume.ForeColor = Color.DarkGoldenrod;
                flyStatus.BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                lblStatus.Text = "Kritis";
                lblStatus.BackColor = Color.MistyRose;
                lblStatus.ForeColor = Color.Red;
                lblVolume.ForeColor = Color.Red;
                flyStatus.BackColor = Color.MistyRose;
            }
        }

        private void DataTPS_Load(object sender, EventArgs e)
        {

        }

        private void btnAjukanPengangkutan_Click(object sender, EventArgs e)
        {
            if (DataTps != null)
            {
                AjukanClicked?.Invoke(this, DataTps);
            }
        }
    }
}
