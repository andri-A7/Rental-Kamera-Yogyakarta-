using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
public class PeminjamanController
{
    private PeminjamanRepository _repository;
    public PeminjamanController(DbContext connection) => this._repository = new PeminjamanRepository(connection);
    private bool validasiInput(Peminjaman peminjaman)
    {
        if (string.IsNullOrEmpty(peminjaman.Nama) || string.IsNullOrEmpty(peminjaman.Alamat)) return false;
        return true;
    }
    public int AddPinjam(Peminjaman peminjaman)
    {
        int result = 0;
        using (DbContext connect = new DbContext())
        {
            this._repository = new PeminjamanRepository(connect);
            result = this._repository.AddPeminjaman(peminjaman);
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


    public List<Peminjaman> GetAllPeminjaman()
    {
        List<Peminjaman> products = new List<Peminjaman>();

        using (DbContext connect = new DbContext())
        {
            this._repository = new PeminjamanRepository(connect);
            products = this._repository.GetAllPeminjaman();
        }

        return products;
    }
    public int DeleteAlat(int id)
    {
        int result = 0;
        using (DbContext connect = new DbContext())
        {
            this._repository = new PeminjamanRepository(connect);
            result = this._repository.Deletepeminjaan(id);
        }
        return _repository.Deletepeminjaan(id);
    }
    public int UpdPinjam(Peminjaman pinjam)
    {
        int result = 0;
        using (DbContext connect = new DbContext())
        {
            this._repository = new PeminjamanRepository(connect);
            result = this._repository.UpdAlat(pinjam);
        }

        if (result == 1)
        {
            MessageBox.Show("Peminjaman Berhasil DiUpdate!", "Informasi",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Peminjaman Gagal Di Update!", "Peringatan",
           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        return result;
    }
}
