using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalKamera.View
{
    public partial class FormKamera : Form
    {
        private KameraController controller;
        private List<Kamera> listKamera = new List<Kamera>();

        public FormKamera()
        {
            InitializeComponent();

            DbContext connection = new DbContext();
            this.controller = new KameraController(connection);

            Inisialisasi();
        }

        private void Inisialisasi()
        {
            this.lvwKamera.View = System.Windows.Forms.View.Details;
            this.lvwKamera.FullRowSelect = true;
            this.lvwKamera.GridLines = true;

            this.lvwKamera.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.lvwKamera.Columns.Add("ID Kamera", 100, HorizontalAlignment.Center);
            this.lvwKamera.Columns.Add("Merk Kamera", 200, HorizontalAlignment.Center);
            this.lvwKamera.Columns.Add("Tipe Kamera", 80, HorizontalAlignment.Center);
            this.lvwKamera.Columns.Add("Haarga", 100, HorizontalAlignment.Center);
        }

        private void LoadDataProducts()
        {
            this.lvwKamera.Items.Clear();
            this.listKamera = this.controller.GetAll();

            foreach (Kamera kamera in this.listKamera)
            {
                int number = lvwKamera.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(kamera.id);
                items.SubItems.Add(kamera.merk);
                items.SubItems.Add(kamera.tipe);
                items.SubItems.Add(kamera.harga.ToString());
                this.lvwKamera.Items.Add(items);
            }
        }

        private void OnCreateHandler(Kamera kamera)
        {
            this.listKamera.Add(kamera);

            int number = this.lvwKamera.Items.Count + 1;
            ListViewItem items = new ListViewItem(number.ToString());
            items.SubItems.Add(kamera.id);
            items.SubItems.Add(kamera.merk);
            items.SubItems.Add(kamera.tipe);
            items.SubItems.Add(kamera.harga);
            this.lvwKamera.Items.Add(items);
        }

        private void btnTampilkan_Click(object sender, System.EventArgs e)
        {
            this.LoadDataProducts();
        }

        private void btnTambah_Click(object sender, System.EventArgs e)
        {
            int result = 0;

            Kamera kamera = new Kamera();
            kamera.id = this.idKamera.Text;
            kamera.merk = this.merekKamera.Text;
            kamera.tipe = this.seriKamera.Text;
            kamera.harga = this.hargaKamera.Text;

            result = this.controller.AddKamera(kamera);

            if (result > 0)
            {
                this.OnCreateHandler(kamera);

                this.idKamera.Clear();
                this.merekKamera.Clear();
                this.seriKamera.Clear();
                this.hargaKamera.Clear();
            }
        }
    }
}
