using System.Drawing.Drawing2D;

namespace JAGA_TPS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form RegistrasiJagaTPS
            RegistrasiJagaTPS formProfil = new RegistrasiJagaTPS();
            formProfil.Show();

            // Menyembunyikan form LoginPage
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Periksa email dan password
            // 1. Mengambil input pengguna
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // 2. Validasi input kosong
            if (email == "" || password == "")
            {
                MessageBox.Show("Email dan password wajib diisi!");
                return;
            }

            // 3. Mencari akun dalam List
            User akunDitemukan = null;

            foreach (User user in UserStore.Users)
            {
                if (user.Email.Equals(
                    email,
                    StringComparison.OrdinalIgnoreCase)
                    && user.Password == password)
                {
                    akunDitemukan = user;
                    break;
                }
            }

            // 4. Memeriksa hasil pencarian
            if (akunDitemukan != null)
            {
                MessageBox.Show(
                    "Login berhasil!\nSelamat datang, " +
                    akunDitemukan.NamaLengkap
                );

                // Menampilkan role pengguna
                MessageBox.Show("Role: " + akunDitemukan.Role);

                // Membuka Dashboard dengan nama pengguna
                DashboardPengisianHarian dashboard =
                    new DashboardPengisianHarian(akunDitemukan.NamaLengkap);

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password salah!");
            }



        }
    }
}
