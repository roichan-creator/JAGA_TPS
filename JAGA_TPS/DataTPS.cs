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
        public DataTPS()
        {
            InitializeComponent();
        }

        public void TampilkanData(TPSModel tps)
        {
            lblNamaTPS.Text = tps.NamaTPS;

            // Menampilkan persentase
            lblVolume.Text = tps.Volume + "%";

            lblJadwal.Text = "Jadwal Rutin: " + tps.JadwalRutin;

            // Menentukan status TPS
            if (tps.Volume <= 40)
            {
                lblStatus.Text = "Aman";
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.ForeColor = Color.DarkGreen;
            }
            else if (tps.Volume <= 75)
            {
                lblStatus.Text = "Normal";
                lblStatus.BackColor = Color.LightGoldenrodYellow;
                lblStatus.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                lblStatus.Text = "Kritis";
                lblStatus.BackColor = Color.MistyRose;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void DataTPS_Load(object sender, EventArgs e)
        {

        }
    }
}
