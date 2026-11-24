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
            // Mengambil input pengguna
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input kosong
            if (email == "" || password == "")
            {
                MessageBox.Show("Email dan password wajib diisi!");
                return;
            }

            // Mencari akun dalam List
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

            // Memeriksa hasil pencarian
            if (akunDitemukan != null)
            {
                MessageBox.Show(
                    "Login berhasil!\nSelamat datang, " +
                    akunDitemukan.NamaLengkap
                );

                // Menampilkan role pengguna
                MessageBox.Show("Role: " + akunDitemukan.Role);

                // Menyimpan akun yang berhasil login ke UserStore
                UserStore.CurrentUser = akunDitemukan;

                // Membuka Dashboard dengan nama pengguna
                DashboardPengisianHarian dashboard = new DashboardPengisianHarian();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password salah!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
