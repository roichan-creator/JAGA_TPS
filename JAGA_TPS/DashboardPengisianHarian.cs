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
            // Membersihkan kartu sebelumnya
            tblDaftarTPS.Controls.Clear();

            // Mengambil data TPS
            foreach (TPSModel tps in TPSStore.DaftarTPS)
            {
                // Hanya TPS yang sudah diperiksa ditampilkan
                if (tps.SudahDiperiksa)
                {
                    DataTPS kartu = new DataTPS();

                    kartu.TampilkanData(tps);

                    tblDaftarTPS.Controls.Add(kartu);
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

            // Mengambil nilai volume
            //tps.Volume = (int)nudVolume.Value;
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

       
    }
}
