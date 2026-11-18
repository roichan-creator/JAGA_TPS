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
    public partial class RegistrasiJagaTPS : Form
    {
        public RegistrasiJagaTPS()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkMasuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form Login
            LoginPage formProfil = new LoginPage();
            formProfil.Show();

            // Menyembunyikan form RegistrasiJagaTPS
            this.Hide();
        }
    }
}
