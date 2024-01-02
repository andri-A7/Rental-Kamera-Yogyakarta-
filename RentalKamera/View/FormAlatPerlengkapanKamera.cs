using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalKamera.View
{
    public partial class FormAlatPerlengkapanKamera : Form
    {
        private AlatController _controller;
        public FormAlatPerlengkapanKamera()
        {
            
            InitializeComponent();

            this.lvwAlat.SelectedIndexChanged += new System.EventHandler(this.lvwAlat_SelectedIndexChanged);
            DbContext connection = new DbContext();
            this._controller = new AlatController(connection);
            Inisialisasi();
        }
        private void Inisialisasi()
        {
            this.lvwAlat.View = System.Windows.Forms.View.Details;
            this.lvwAlat.FullRowSelect = true;
            this.lvwAlat.GridLines = true;
            this.lvwAlat.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.lvwAlat.Columns.Add("ID Alat", 100, HorizontalAlignment.Center);
            this.lvwAlat.Columns.Add("Jenis Alat", 200, HorizontalAlignment.Center);
            this.lvwAlat.Columns.Add("Seri Alat", 80, HorizontalAlignment.Center);
            this.lvwAlat.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
        }
        private void LoadDataAlat()
        {
            List<Alat> listalat = _controller.GetAllAlat(); 
            lvwAlat.Items.Clear();

            foreach (Alat alat in listalat)
            {
                int number = lvwAlat.Items.Count + 1;
                ListViewItem item = new ListViewItem(number.ToString());
                item.SubItems.Add(alat.Id.ToString()); 
                item.SubItems.Add(alat.Jenis);
                item.SubItems.Add(alat.Seri);
                item.SubItems.Add(alat.Jumlah.ToString()); 
                lvwAlat.Items.Add(item);
            }
        }

        private void OnCreateHandler(Alat alat)
        {
            int number = lvwAlat.Items.Count + 1;
            ListViewItem item = new ListViewItem(number.ToString());
            item.SubItems.Add(alat.Id);
            item.SubItems.Add(alat.Jenis);
            item.SubItems.Add(alat.Seri);
            item.SubItems.Add(alat.Jumlah.ToString());
            lvwAlat.Items.Add(item);
        }

        private void btn_tmbh_alat_Click(object sender, System.EventArgs e)
        {
            Alat alat = new Alat();
            int result = 0;
            
            alat.Jenis = textBox_jenis_alat.Text;
            alat.Seri = textBox_seri_alat.Text;
            alat.Jumlah = textBox_jumlah_alat.Text;

            result = _controller.AddAlat(alat);

            if (result > 0)
            {
                OnCreateHandler(alat);

                textBox_jenis_alat.Clear();
                textBox_seri_alat.Clear();
                textBox_jumlah_alat.Clear();
            }
            this.LoadDataAlat();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.LoadDataAlat();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (lvwAlat.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih alat yang akan diupdate");
                return;
            }

            var selectedItem = lvwAlat.SelectedItems[0];
            Alat alat = new Alat();
            alat.Id = selectedItem.SubItems[1].Text; // ID Alat
            alat.Jenis = textBox_jenis_alat.Text;
            alat.Seri = textBox_seri_alat.Text;
            alat.Jumlah = textBox_jumlah_alat.Text;

            int result = _controller.UpdAlat(alat);

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diupdate");
                this.LoadDataAlat(); // Refresh ListView
            }
            else
            {
                MessageBox.Show("Data gagal diupdate");
            }
        }
        private void lvwAlat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwAlat.SelectedItems.Count == 0)
                return;

            var selectedItem = lvwAlat.SelectedItems[0];
            label5.Text = selectedItem.SubItems[1].Text;
            textBox_jenis_alat.Text = selectedItem.SubItems[2].Text;
            textBox_seri_alat.Text = selectedItem.SubItems[3].Text;
            
            textBox_jumlah_alat.Text = selectedItem.SubItems[4].Text;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (lvwAlat.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih alat yang akan dihapus");
                return;
            }

            var selectedItem = lvwAlat.SelectedItems[0];
            int alatId = Convert.ToInt32(label5.Text); 

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
                    LoadDataAlat(); // Muat ulang data ke ListView
                }
                else
                {
                    MessageBox.Show("Alat berhasil dihapus");
                }
            }
        }
    }
}
