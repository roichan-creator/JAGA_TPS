using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void linkMasuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form Login
            LoginPage formProfil = new LoginPage();
            formProfil.Show();

            // Menyembunyikan form RegistrasiJagaTPS
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Mengambil data dari TextBox
            string nama = txtUsername.Text.Trim();
            string idizinkerja = txtNamaInstansi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input kosong
            if (nama == "" || idizinkerja == "" ||
                email == "" || password == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            // Validasi email
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            // Memeriksa pilihan role
            string role = "";

            if (rbPengelola.Checked)
            {
                role = "Pengelola TPS";
            }
            else if (rbOperator.Checked)
            {
                role = "Operator Pengangkutan";
            }
            else if (rbPenanggungJawab.Checked)
            {
                role = "Penanggung Jawab";
            }
            else
            {
                MessageBox.Show("Silakan pilih peran pengguna!");
                return;
            }

            // Memeriksa persetujuan
            if (!chkPersetujuan.Checked)
            {
                MessageBox.Show("Anda harus menyetujui ketentuan!");
                return;
            }
            ;

            User penggunaBaru = new User();

            penggunaBaru.NamaLengkap = nama;
            penggunaBaru.IdIzinKerja = idizinkerja;
            penggunaBaru.Email = email;
            penggunaBaru.Password = password;
            penggunaBaru.Role = role;


            // Simpan akun
            UserStore.Users.Add(penggunaBaru);

            MessageBox.Show(
                "Registrasi berhasil! Silakan login."
            );

            // Kembali ke halaman login
            LoginPage login = new LoginPage();
            login.Show();

            this.Hide();

        }
    }
}
