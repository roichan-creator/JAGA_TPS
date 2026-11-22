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
            //lblIdTPS.Text = "TPS-ID: " + tps.Id;
            lblVolume.Text = tps.Volume + "%";
            lblJadwal.Text = "Jadwal Rutin: " + tps.JadwalRutin;
        }

        private void DataTPS_Load(object sender, EventArgs e)
        {

        }
    }
}
