using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JAGA_TPS
{
    public partial class DashboardPengisianHarian : Form
    {

        public DashboardPengisianHarian(string nama)
        {
            InitializeComponent();

            lblNamaUser.Text = nama;

            MuatDaftarLokasiTPS();
            TampilkanDaftarTPS();

        }



        private void MuatDaftarLokasiTPS()
        {
            // Mengosongkan pilihan sebelumnya
            cmbLokasiTPS.Items.Clear();

            // Mengambil data TPS dari TPSStore
            foreach (TPSModel tps in TPSStore.DaftarTPS)
            {
                cmbLokasiTPS.Items.Add(tps.NamaTPS);
            }

            // Tidak memilih lokasi secara otomatis
            cmbLokasiTPS.SelectedIndex = -1;
        }

        private void DashboardPengisianHarian_Load(object sender, EventArgs e)
        {

        }

        private void btnTambahPTS_Click(object sender, EventArgs e)
        {
            // Meminta nama TPS
            string namaTPS = Interaction.InputBox(
                "Masukkan nama TPS:",
                "Tambah TPS",
                ""
            );

            if (string.IsNullOrWhiteSpace(namaTPS))
            {
                return;
            }

            // Meminta lokasi TPS
            string lokasi = Interaction.InputBox(
                "Masukkan lokasi TPS:",
                "Tambah TPS",
                ""
            );

            if (string.IsNullOrWhiteSpace(lokasi))
            {
                return;
            }

            // Meminta jadwal rutin TPS
            string jadwalrutin = Interaction.InputBox(
                "Masukkan jadwal rutin TPS:",
                "Tambah TPS",
                ""
            );

            // Membuat data TPS baru
            TPSModel tpsBaru = new TPSModel();

            tpsBaru.Id = "TPS-" +
                (TPSStore.DaftarTPS.Count + 1).ToString("D3");

            tpsBaru.NamaTPS = namaTPS;
            tpsBaru.Lokasi = lokasi;
            tpsBaru.Volume = 0;
            tpsBaru.SudahDiperiksa = false;
            tpsBaru.JadwalRutin = jadwalrutin;

            // Menyimpan data TPS
            TPSStore.DaftarTPS.Add(tpsBaru);

            // Memperbarui pilihan lokasi TPS
            MuatDaftarLokasiTPS();

            MessageBox.Show(
                "TPS berhasil ditambahkan!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void TampilkanDaftarTPS()
        {
            // 1. Hapus kartu TPS yang lama agar tidak menumpuk saat daftar di-refresh
            tblDaftarTPS.Controls.Clear();

            // 2. Iterasi seluruh data TPS yang tersimpan di TPSStore
            foreach (TPSModel tps in TPSStore.DaftarTPS)
            {
                // 3. Hanya tampilkan kartu untuk TPS yang sudah melalui proses pemeriksaan harian
                if (tps.SudahDiperiksa)
                {
                    // 4. Buat instance User Control kartu TPS dan isi tampilannya sesuai data TPS saat ini
                    DataTPS itemTps = new DataTPS();
                    itemTps.TampilkanData(tps);

                    // 5. Pasang event saat tombol "Ajukan Pengangkutan" di dalam kartu TPS diklik
                    itemTps.AjukanClicked += (sender, tpsObjek) =>
                    {
                        // 6. Buka form DashboardPengajuan dan kirimkan data TPS yang dipilih ke form tersebut
                        DashboardPengajuan formPengajuan = new DashboardPengajuan();
                        formPengajuan.MuatDataTps(tpsObjek);
                        formPengajuan.Show();

                        // 7. Sembunyikan DashboardPengisianHarian agar user berpindah ke halaman pengajuan
                        this.Hide();
                    };

                    // 8. Masukkan kartu TPS ke dalam container (TableLayoutPanel / FlowLayoutPanel)
                    tblDaftarTPS.Controls.Add(itemTps);
                }
            }
        }

        private void btnSimpanPemeriksaan_Click(object sender, EventArgs e)
        {
            if (cmbLokasiTPS.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih lokasi TPS!");
                return;
            }

            string namaTPS = cmbLokasiTPS.SelectedItem.ToString();

            TPSModel tps = TPSStore.DaftarTPS.Find(x =>
                x.NamaTPS == namaTPS
            );

            if (tps == null)
            {
                MessageBox.Show("Data TPS tidak ditemukan!");
                return;
            }

            // Mengambil nilai estimasi volume sampah
            tps.Volume = (int)nudVolume.Value;

            // Mengubah status pemeriksaan
            tps.SudahDiperiksa = true;

            // Memperbarui tampilan Dashboard
            TampilkanDaftarTPS();

            MessageBox.Show(
                "Hasil pemeriksaan berhasil disimpan!"
            );
        }

        private void btnTambahFoto_Click(object sender, EventArgs e)
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
                        pictureDokumentasiFoto.Image = Image.FromFile(openFileDialog.FileName);

                        // Menyesuaikan ukuran gambar agar pas di dalam PictureBox
                        pictureDokumentasiFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memuat gambar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHapusFoto_Click(object sender, EventArgs e)
        {
            // Membersihkan gambar dari PictureBox
            if (pictureDokumentasiFoto.Image != null)
            {
                pictureDokumentasiFoto.Image.Dispose(); // Membersihkan memori gambar sebelumnya
                pictureDokumentasiFoto.Image = null;
            }
            else
            {
                MessageBox.Show("Tidak ada foto untuk dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void linkLabelProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka Form RegistrasiJagaTPS
            ProfileScreen formProfil = new ProfileScreen();
            formProfil.Show();

            // Menyembunyikan form LoginPage
            this.Hide();
        }
    }
}
