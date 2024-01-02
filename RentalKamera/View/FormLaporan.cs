using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using OfficeOpenXml;
using System.IO;

namespace RentalKamera.View
{
    public partial class FormLaporan : Form
    {
        private PengembalianController _controller;

        public FormLaporan()
        {
            InitializeComponent();
            this.lvw_laporan.SelectedIndexChanged += new System.EventHandler(this.lvw_laporan_SelectedIndexChanged);
            DbContext connection = new DbContext();
            this._controller = new PengembalianController(connection);
            Inisialisasi();
            LoadLaporan();
            
        }
        

        private void ExportToExcel()
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 2
            };
        
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Laporan");
        
                    // Tambahkan header
                    for (int i = 0; i < lvw_laporan.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = lvw_laporan.Columns[i].Text;
                    }
        
                    // Tambahkan isi
                    for (int i = 0; i < lvw_laporan.Items.Count; i++)
                    {
                        for (int j = 0; j < lvw_laporan.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = lvw_laporan.Items[i].SubItems[j].Text;
                        }
                    }
        
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                }
        
                MessageBox.Show("Data berhasil diekspor ke Excel", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Inisialisasi()
        {
            this.lvw_rincian.View = System.Windows.Forms.View.Details;
            this.lvw_rincian.FullRowSelect = true;
            this.lvw_rincian.GridLines = true;
            this.lvw_rincian.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.lvw_rincian.Columns.Add("Hari", 200, HorizontalAlignment.Center);
            this.lvw_rincian.Columns.Add("Total", 200, HorizontalAlignment.Center);
            this.lvw_laporan.View = System.Windows.Forms.View.Details;
            this.lvw_laporan.FullRowSelect = true;
            this.lvw_laporan.GridLines = true;
            this.lvw_laporan.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.lvw_laporan.Columns.Add("ID Customer", 80, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Nama", 200, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Alamat", 200, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Tanggal Peminjaman", 200, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Tanggal Pengembalian", 200, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Total Pembayaran", 100, HorizontalAlignment.Right);
            this.lvw_laporan.Columns.Add("Kamera", 100, HorizontalAlignment.Center);
            this.lvw_laporan.Columns.Add("Alat", 100, HorizontalAlignment.Center);
        }
        private void lvw_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
        }
        private void LoadLaporan()
        {
            List<Pengembalian> listLaporan = _controller.GetAllLaporan();
            lvw_laporan.Items.Clear();

            foreach (Pengembalian laporan in listLaporan)
            {
                ListViewItem item = new ListViewItem(laporan.Id.ToString());
                item.SubItems.Add(laporan.Id.ToString());
                item.SubItems.Add(laporan.Nama);
                item.SubItems.Add(laporan.Alamat);
                item.SubItems.Add(laporan.TanggalPeminjaman.ToShortDateString());
                item.SubItems.Add(laporan.TanggalPengembalian.ToShortDateString());
                decimal.TryParse(laporan.Total, out decimal totalPembayaran);
                item.SubItems.Add(totalPembayaran.ToString("C"));
                item.SubItems.Add(laporan.Kamera);
                item.SubItems.Add(laporan.Alat);
                // Tambahkan format yang sesuai untuk harga, misalnya dalam format mata uang
               

                lvw_laporan.Items.Add(item);
            }
        }


        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLaporan();
        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void LoadRincian()
        {
            if (int.TryParse(label_cus.Text, out int searchId))
            {
                List<Pengembalian> listLaporan = _controller.SbyId(searchId);
                lvw_rincian.Items.Clear();

                foreach (Pengembalian laporan in listLaporan)
                {
                    lvw_rincian.Items.Clear();
                    int number = lvw_rincian.Items.Count + 1;
                    ListViewItem item = new ListViewItem(number.ToString());
                    item.SubItems.Add(laporan.HariPeminjaman.ToString());
                    decimal.TryParse(laporan.Total, out decimal totalPembayaran);
                    item.SubItems.Add(totalPembayaran.ToString("C"));
                    lvw_rincian.Items.Add(item);

                }
            }
            else
            {
                MessageBox.Show("ID yang dimasukkan tidak valid.");
                return; // Keluar dari metode jika format tidak valid
            }
           
        }
        private void lvw_laporan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_laporan.SelectedItems.Count == 0)
                return; 

            var selectedItem = lvw_laporan.SelectedItems[0];
            label_cus.Text = selectedItem.SubItems[1].Text;
            label_nama.Text = selectedItem.SubItems[2].Text;
            label_alamat.Text = selectedItem.SubItems[3].Text;
            label_kamera.Text = selectedItem.SubItems[7].Text;
            label_alat.Text = selectedItem.SubItems[8].Text;
            LoadRincian();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void button2_Click(object sender, EventArgs e)
        {

                
        }
    }
 }
