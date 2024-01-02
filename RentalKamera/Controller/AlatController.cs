
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Common;

namespace RentalKamera.Controller
{
    public class AlatController
    {
        private AlatRepository _repository;

        public AlatController(DbContext connection) => this._repository = new AlatRepository(connection);
        private bool validasiInput(Alat alat)
        {
            if ( string.IsNullOrEmpty(alat.Jenis)) return false;
            if (string.IsNullOrEmpty(alat.Seri) || string.IsNullOrEmpty(alat.Jumlah)) return false;
            return true;
        }
        public int AddAlat(Alat alat)
        {
            int result = 0;

            if (!this.validasiInput(alat))
            {
                MessageBox.Show("Input Tidak Boleh Kosong!!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (int.TryParse(alat.Jumlah, out int jumlah))
            {
                alat.Jumlah = jumlah.ToString();
            }
            else
            {
                MessageBox.Show("Input Tidak Valid!", "Warning",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext connect = new DbContext())
            {
                this._repository = new AlatRepository(connect);
                result = this._repository.addAlat(alat);
            }

            if (result == 1)
            {
                MessageBox.Show("Alat Berhasil Ditambahkan!", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Alat Gagal Ditambahkan!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int UpdAlat(Alat alat)
        {
            int result = 0;

            if (!this.validasiInput(alat))
            {
                MessageBox.Show("Input Tidak Boleh Kosong!!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (int.TryParse(alat.Jumlah, out int jumlah))
            {
                alat.Jumlah = jumlah.ToString();
            }
            else
            {
                MessageBox.Show("Input Tidak Valid!", "Warning",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext connect = new DbContext())
            {
                this._repository = new AlatRepository(connect);
                result = this._repository.UpdateAlat(alat);
            }

            if (result == 1)
            {
                MessageBox.Show("Alat Berhasil Ditambahkan!", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Alat Gagal Ditambahkan!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int DeleteAlat(int id)
        {
            int result = 0;
            using (DbContext connect = new DbContext())
            {
                this._repository = new AlatRepository(connect);
                result = this._repository.DeleteAlat(id);
            }
            return _repository.DeleteAlat(id);
        }
        public List<Alat> GetAllAlat()
        {
            List<Alat> products = new List<Alat>();

            using (DbContext connect = new DbContext())
            {
                this._repository = new AlatRepository(connect);
                products = this._repository.GetAllAlat();
            }

            return products;
        }
        public List<Alat> GetComboAlat()
        {
            List<Alat> products = new List<Alat>();

            using (DbContext connect = new DbContext())
            {
                this._repository = new AlatRepository(connect);
                products = this._repository.GetAlat();
            }

            return products;
        }

    }
}
