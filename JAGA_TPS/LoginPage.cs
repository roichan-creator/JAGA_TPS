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
    }
}
