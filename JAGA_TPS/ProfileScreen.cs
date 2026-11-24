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
    public partial class ProfileScreen : Form
    {
        public ProfileScreen()
        {
            InitializeComponent();

            if (UserStore.CurrentUser != null)
            {
                lblNamaUser.Text = UserStore.CurrentUser.NamaLengkap;
                labelIdentitas.Text = UserStore.CurrentUser.NamaLengkap;
                labelID.Text = UserStore.CurrentUser.IdIzinKerja;
                labelEmail.Text = UserStore.CurrentUser.Email;
            }
        }

<<<<<<< HEAD
        private void labelSistemResikSampah_Click(object sender, EventArgs e)
        {

=======
        private void linkLabelProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form RegistrasiJagaTPS
            DashboardPengisianHarian formharian = new DashboardPengisianHarian();
            formharian.Show();

            // Menyembunyikan form LoginPage
            this.Hide();
>>>>>>> 717b529d008d63fab9f4477e1efe695e55177b11
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
