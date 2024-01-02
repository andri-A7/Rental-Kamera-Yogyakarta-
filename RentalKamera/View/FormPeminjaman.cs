using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalKamera.View
{
    public partial class FormPeminjaman : Form
    {
        private PeminjamanController _controller;
        private KameraController _controllerkamera;
        private AlatController _controlleralat;
        public FormPeminjaman()
        {
            InitializeComponent();
            DbContext connection = new DbContext();
            this.lvwPeminjaman.SelectedIndexChanged += new System.EventHandler(this.lvwAlat_SelectedIndexChanged);
            this._controller = new PeminjamanController(connection);
            this._controllerkamera = new KameraController(connection);
            this._controlleralat = new AlatController(connection);
            Inisialisasi();
            FillKameraComboBox();
            FillAlatComboBox();
            LoadDataPeminjaman();
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
            this.lvwPeminjaman.Columns.Add("Tanggal Peminjaman", 100, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Kamera", 80, HorizontalAlignment.Center);
            this.lvwPeminjaman.Columns.Add("Alat", 80, HorizontalAlignment.Center);
        }
        private void LoadDataPeminjaman()
        {
            List<Peminjaman> listpeminjaman = _controller.GetAllPeminjaman();
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
                lvwPeminjaman.Items.Add(item);
            }
        }
        private void OnCreateHandler(Peminjaman peminjaman)
        {

            int number = lvwPeminjaman.Items.Count + 1;
            ListViewItem item = new ListViewItem(number.ToString());
            item.SubItems.Add(peminjaman.Id.ToString());
            item.SubItems.Add(peminjaman.Nama);
            item.SubItems.Add(peminjaman.Alamat);
            item.SubItems.Add(peminjaman.TanggalPeminjaman.ToString());
            lvwPeminjaman.Items.Add(item);
        }
        private void btn_tmbh_pmj_Click(object sender, System.EventArgs e)
        {
            int result = 0;

            Peminjaman kamera = new Peminjaman();
            kamera.Nama = this.textBox_Nama.Text;
            kamera.Alamat = this.textBox_alamat.Text;
            kamera.TanggalPeminjaman = this.dateTimePicker_pj.Value;
            kamera.Alat = this.comboBox_alat.Text;
            kamera.Kamera = this.comboBox_kamera.Text;
            result = this._controller.AddPinjam(kamera);

            if (result > 0)
            {
                this.OnCreateHandler(kamera);

                this.textBox_Nama.Clear();
                this.textBox_alamat.Clear();
            }
            this.LoadDataPeminjaman();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.LoadDataPeminjaman();
        }
        private void FillKameraComboBox()
        {
            List<Kamera> kameras = _controllerkamera.GetKamera();

            comboBox_kamera.DataSource = kameras;
            comboBox_kamera.DisplayMember = "tipe";
        }
        private void FillAlatComboBox()
        {
            List<Alat> alat = _controlleralat.GetComboAlat();

            comboBox_alat.DataSource = alat;
            comboBox_alat.DisplayMember = "Seri";
        }
        private void lvwAlat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Peminjaman pinjam = new Peminjaman();
            if (lvwPeminjaman.SelectedItems.Count == 0)
                return;

            var selectedItem = lvwPeminjaman.SelectedItems[0];
            if (int.TryParse(selectedItem.SubItems[1].Text, out int id))
            {
                 label7.Text = id.ToString(); // Menyimpan ID yang dipilih
            }
            textBox_Nama.Text = selectedItem.SubItems[2].Text;
            textBox_alamat.Text = selectedItem.SubItems[3].Text;
            if (DateTime.TryParse(selectedItem.SubItems[4].Text, out DateTime parsedDate))
            {
                dateTimePicker_pj.Value = parsedDate;
            }
            else
            {
                // Handle parsing error, misalnya set nilai default
                dateTimePicker_pj.Value = DateTime.Now;
            }
            comboBox_alat.Text = selectedItem.SubItems[5].Text;
            comboBox_kamera.Text = selectedItem.SubItems[6].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lvwPeminjaman.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih alat yang akan dihapus");
                return;
            }

            var selectedItem = lvwPeminjaman.SelectedItems[0];
            int alatId = Convert.ToInt32(selectedItem.SubItems[1].Text); // Asumsi ID ada di SubItem index 1

            // Konfirmasi penghapusan
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus alat ini?",
                                                 "Konfirmasi Penghapusan",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int result = _controller.DeleteAlat(alatId);
                if (result > 0)
                {
                    MessageBox.Show("Gagal menghapus alat ");
                    this.LoadDataPeminjaman();
                }
                else
                {
                    MessageBox.Show("Alat berhasil dihapus");
                }
                MessageBox.Show("Peminjaman berhasil dihapus");
                    LoadDataPeminjaman(); // Muat ulang data ke ListView
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Handler untuk tombol update peminjaman
            if (lvwPeminjaman.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih peminjaman yang akan diperbarui");
                return;
            }

            Peminjaman peminjaman = new Peminjaman
            {
                Id = Convert.ToInt32(label7.Text), // Gunakan ID yang telah disimpan
                Nama = textBox_Nama.Text,
                Alamat = textBox_alamat.Text,
                TanggalPeminjaman = dateTimePicker_pj.Value,
                Alat = comboBox_alat.SelectedValue.ToString(),
                Kamera = comboBox_kamera.SelectedValue.ToString()
            };

            int result = _controller.UpdPinjam(peminjaman);

            if (result > 0)
            {
                LoadDataPeminjaman(); // Segarkan ListView
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data peminjaman");
            }
        }
    }

}
