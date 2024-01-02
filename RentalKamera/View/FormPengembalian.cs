using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
namespace RentalKamera.View
{
    public partial class FormPengembalian : Form
    {
        private PengembalianController _controller;
        private PeminjamanController _controllerpeminjaman;
        private KameraController _controllerkamera;
        private AlatController _controlleralat;
        public FormPengembalian()
        {
            InitializeComponent();
            DbContext connection = new DbContext();
            this.lvwPeminjaman.SelectedIndexChanged += new System.EventHandler(this.lvwAlat_SelectedIndexChanged);
            this._controller = new PengembalianController(connection);
            this._controllerpeminjaman = new PeminjamanController(connection);
            this._controllerkamera = new KameraController(connection);
            this._controlleralat = new AlatController(connection);
            LoadDataPeminjaman();
            Inisialisasi();
        }
        private void Inisialisasi()
        {
            this.lvwPeminjaman.View = System.Windows.Forms.View.Details;
            this.lvwPeminjaman.FullRowSelect = true;
            this.lvwPeminjaman.GridLines = true;
            this.lvwPeminjaman.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.lvwPeminjaman.Columns.Add("ID Customer", 100, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Nama", 200, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Alamat", 80, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Tanggal Peminjaman", 200, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Kamera", 80, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Alat", 80, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Hari Peminjaman", 80, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Harga Kamera", 80, HorizontalAlignment.Center);
        }
        private void LoadDataPeminjaman()
        {
            List<Peminjaman> listpeminjaman = _controllerpeminjaman.GetAllPeminjaman();
            lvwPeminjaman.Items.Clear();

            foreach (Peminjaman pinjam in listpeminjaman)
            {
                int number = lvwPeminjaman.Items.Count + 1;
                ListViewItem item = new ListViewItem(number.ToString());
                item.SubItems.Add(pinjam.Id.ToString());
                item.SubItems.Add(pinjam.Nama);
                item.SubItems.Add(pinjam.Alamat);
                item.SubItems.Add(pinjam.TanggalPeminjaman.ToString());
                item.SubItems.Add(pinjam.Kamera.ToString());
                item.SubItems.Add(pinjam.Alat.ToString());
                
                TimeSpan selisih = DateTime.Now - pinjam.TanggalPeminjaman;
                int jumlahHariPeminjaman = selisih.Days;

                item.SubItems.Add(jumlahHariPeminjaman.ToString());
                item.SubItems.Add(pinjam.Harga.ToString());
                lvwPeminjaman.Items.Add(item);
            }
        }
        private void lvwAlat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Peminjaman pinjam = new Peminjaman();
            if (lvwPeminjaman.SelectedItems.Count == 0)
                return;

            var selectedItem = lvwPeminjaman.SelectedItems[0];
            if (int.TryParse(selectedItem.SubItems[1].Text, out int id))
            {
                label_id.Text = id.ToString(); // Menyimpan ID yang dipilih
            }
            label_nama.Text = selectedItem.SubItems[2].Text;
            label_alamat.Text = selectedItem.SubItems[3].Text;
            label_peminjaman.Text = selectedItem.SubItems[4].Text;
            label_kamera.Text = selectedItem.SubItems[5].Text;
            label_alat.Text = selectedItem.SubItems[6].Text;
            label_hari.Text = selectedItem.SubItems[7].Text;
            label_harga_kamera.Text = selectedItem.SubItems[8].Text;
            // Konversi jumlah hari dari label_hari ke integer
            int.TryParse(label_hari.Text, out int jumlahHari);

            // Konversi harga kamera dari label_harga_kamera ke integer
            int.TryParse(label_harga_kamera.Text, out int hargaKamera);

            // Hitung total harga
            int totalHarga = jumlahHari * hargaKamera;

            // Tampilkan total harga di label_total
            label_total.Text = totalHarga.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pengembalian pengembalian = new Pengembalian
            {
                Nama = label_nama.Text,
                Alamat = label_alamat.Text,
                TanggalPengembalian = dateTimePicker_pj.Value,
                Total = label_total.Text, // Pastikan validasi dan penanganan kesalahan
                Kamera = label_kamera.Text,
                Alat = label_alat.Text,
            };

            // Konversi TanggalPeminjaman dari label ke DateTime
            if (DateTime.TryParse(label_peminjaman.Text, out DateTime tanggalPeminjaman))
            {
                pengembalian.TanggalPeminjaman = tanggalPeminjaman;
            }
            else
            {
                MessageBox.Show("Format tanggal peminjaman tidak valid.");
                return; // Hentikan eksekusi lebih lanjut karena ada kesalahan input
            }

            int result = _controller.AddPengembalian(pengembalian);
            if (result > 0)
            {
                MessageBox.Show("Data pengembalian berhasil ditambahkan.");
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat menambahkan data pengembalian.");
            }
        }

    }
}
