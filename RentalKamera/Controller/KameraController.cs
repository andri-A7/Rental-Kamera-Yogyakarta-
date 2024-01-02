using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalKamera.Controller
{
    public class KameraController
    {
        private KameraRepository repository;

        public KameraController(DbContext connection) => this.repository = new KameraRepository(connection);

        private bool validasiInput(Kamera kamera)
        {
            if (string.IsNullOrEmpty(kamera.id) || string.IsNullOrEmpty(kamera.merk)) return false;
            if (string.IsNullOrEmpty(kamera.tipe) || string.IsNullOrEmpty(kamera.harga)) return false;
            return true;
        }

        public int AddKamera(Kamera kamera)
        {
            int result = 0;

            if (!this.validasiInput(kamera))
            {
                MessageBox.Show("Input Tidak Boleh Kosong!!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (int.TryParse(kamera.harga, out int harga))
            {
                kamera.harga = harga.ToString();
            }
            else
            {
                MessageBox.Show("Input Tidak Valid!", "Warning",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext connect = new DbContext())
            {
                this.repository = new KameraRepository(connect);
                result = this.repository.addKamera(kamera);
            }

            if (result == 1)
            {
                MessageBox.Show("Kamera Berhasil Ditambahkan!", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kamera Gagal Ditambahkan!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Kamera> GetAll()
        {
            List<Kamera> products = new List<Kamera>();

            using (DbContext connect = new DbContext())
            {
                this.repository = new KameraRepository(connect);
                products = this.repository.GetAll();
            }

            return products;
        }
        public List<Kamera> GetKamera()
        {
            List<Kamera> products = new List<Kamera>();

            using (DbContext connect = new DbContext())
            {
                this.repository = new KameraRepository(connect);
                products = this.repository.GetAllKameras();
            }

            return products;
        }

    }
}
