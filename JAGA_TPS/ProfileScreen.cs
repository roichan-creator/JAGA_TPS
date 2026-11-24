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

            // Menampilkan data user saat ini di halaman profil
            if (UserStore.CurrentUser != null)
            {
                lblNamaUser.Text = UserStore.CurrentUser.NamaLengkap;
                labelIdentitas.Text = UserStore.CurrentUser.NamaLengkap;
                labelID.Text = UserStore.CurrentUser.IdIzinKerja;
                labelEmail.Text = UserStore.CurrentUser.Email;
            }
        }

        private void linkLabelProfil_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form Dashboard PengisianHarian
            DashboardPengisianHarian formHarian = new DashboardPengisianHarian();
            formHarian.Show();

            // Menyembunyikan ProfileScreen
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari akun ini?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                LoginPage formLogin = new LoginPage();


                formLogin.Show();


                this.Close();
            }
        }
    }
}
