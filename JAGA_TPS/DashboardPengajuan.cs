using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGA_TPS
{
    public partial class DashboardPengajuan : Form
    {

        private TPSModel? _tpsTerpilih;
        private Form? _formDashboardAsal;

        public DashboardPengajuan()
        {
            InitializeComponent();
            // Simpan objek yang dikirim
            if (UserStore.CurrentUser != null)
            {
                lblNamaUser.Text = UserStore.CurrentUser.NamaLengkap;
            }

        }

        public void MuatDataTps(TPSModel tps, Form? formAsal = null)
        {
            if (tps == null) return;

            _tpsTerpilih = tps;
            _formDashboardAsal = formAsal;

            // Menentukan status TPS
            if (tps.Volume <= 40)
            {
                lblStatusTPS.Text = "Aman";
                lblStatusTPS.BackColor = Color.LightGreen;
                lblStatusTPS.ForeColor = Color.DarkGreen;
                flyStatus.BackColor = Color.LightGreen;
                pictureBoxStatus.Image = Properties.Resources.CIrcleGreen;
            }
            else if (tps.Volume <= 75)
            {
                lblStatusTPS.Text = "Normal";
                lblStatusTPS.BackColor = Color.LightGoldenrodYellow;
                lblStatusTPS.ForeColor = Color.DarkGoldenrod;
                flyStatus.BackColor = Color.LightGoldenrodYellow;
                pictureBoxStatus.Image = Properties.Resources.Circleyellow;
            }
            else
            {
                lblStatusTPS.Text = "Kritis";
                lblStatusTPS.BackColor = Color.MistyRose;
                lblStatusTPS.ForeColor = Color.Red;
                flyStatus.BackColor = Color.MistyRose;
                pictureBoxStatus.Image = Properties.Resources.Circlered;
            }
            // Menampilkan data TPS
            lblNamaTPS.Text = tps.NamaTPS;
            lblLokasiTPS.Text = tps.Lokasi;
            lblJadwal.Text = tps.JadwalRutin;
        }





        private void btnAjukan_Click(object sender, EventArgs e)
        {
            
            if (_tpsTerpilih == null) return;

            // Ubah status TPS menjadi "Menunggu"
            _tpsTerpilih.Status = "Menunggu";

            MessageBox.Show(
                "Pengajuan pengangkutan berhasil dikirim. Status TPS kini Menunggu.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Kembali ke DashboardPengisianHarian dan refresh daftar TPS
            if (_formDashboardAsal is DashboardPengisianHarian dashboardHarian)
            {
                dashboardHarian.RefreshDaftarTPS();
                dashboardHarian.Show();
            }
            else
            {
                var dashboardBaru = new DashboardPengisianHarian();
                dashboardBaru.Show();
            }

            // Tutup form pengajuan
            this.Close();
        }

        private void btnTambahGambar_Click(object sender, EventArgs e)
        {
            // Membuat instance OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter jenis file gambar yang bisa dipilih
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Pilih Dokumentasi Foto Lapangan";

                // Jika pengguna memilih file dan menekan OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Menampilkan gambar ke PictureBox
                        pictureBoxTambahFoto.Image = Image.FromFile(openFileDialog.FileName);

                        // Menyesuaikan ukuran gambar agar pas di dalam PictureBox
                        pictureBoxTambahFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memuat gambar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void btnHapusFoto_Click(object sender, EventArgs e)
        {
            // Membersihkan gambar dari PictureBox
            if (pictureBoxTambahFoto.Image != null)
            {
                pictureBoxTambahFoto.Image.Dispose(); // Membersihkan memori gambar sebelumnya
                pictureBoxTambahFoto.Image = null;
            }
            else
            {
                MessageBox.Show("Tidak ada foto untuk dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DashboardPengisianHarian formPengisian = new DashboardPengisianHarian();


            formPengisian.Show();


            this.Close();
        }
    }
}
