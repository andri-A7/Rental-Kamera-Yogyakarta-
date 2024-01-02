using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
namespace RentalKamera.Controller
{
    public class PengembalianController
    {
        private PengembalianRepository _repository;
        public PengembalianController(DbContext connection) => this._repository = new PengembalianRepository(connection);
        public int AddPengembalian(Pengembalian kembali)
        {
            int result = 0;
            using (DbContext connect = new DbContext())
            {
                this._repository = new PengembalianRepository(connect);
                result = this._repository.AddPengembalian(kembali);
            }
            if (result == 1)
            {
                MessageBox.Show("Peminjaman Berhasil Ditambahkan!", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Peminjaman Gagal Ditambahkan!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public List<Pengembalian> GetAllLaporan()
        {
            List<Pengembalian> products = new List<Pengembalian>();

            using (DbContext connect = new DbContext())
            {
                this._repository = new PengembalianRepository(connect);
                products = this._repository.GetAllLaporan1();
            }

            return products;
        }
        public List<Pengembalian> SbyId(int id)
        {
            List<Pengembalian> products = new List<Pengembalian>();

            using (DbContext connect = new DbContext())
            {
                this._repository = new PengembalianRepository(connect);
                products = this._repository.searchbyid(id);
            }

            return products;
        }
    }

}
