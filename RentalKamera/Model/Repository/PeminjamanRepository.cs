using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
public class PeminjamanRepository
{
    SQLiteConnection _connection;
    private PeminjamanRepository _repository;
    public PeminjamanRepository(DbContext connection)
    {
        _connection = connection.Conn;

    }
    public int AddPeminjaman(Peminjaman peminjaman)
    {
        int result = 0;
        string sql = "INSERT INTO peminjaman (nama, alamat, tanggal_peminjaman,id_alat,id_kamera) VALUES (@nama, @alamat, @tanggal,@alat,@kamera)";

        using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
        {
            cmd.Parameters.AddWithValue("@nama", peminjaman.Nama);
            cmd.Parameters.AddWithValue("@alamat", peminjaman.Alamat);
            cmd.Parameters.AddWithValue("@tanggal", peminjaman.TanggalPeminjaman);
            cmd.Parameters.AddWithValue("@alat", peminjaman.Alat);
            cmd.Parameters.AddWithValue("@kamera", peminjaman.Kamera);
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }
        }
        return result;
    }
    public List<Peminjaman> GetAllPeminjaman()
    {
        List<Peminjaman> listPeminjaman = new List<Peminjaman>();

        try
        {
            string sql = @"
            SELECT p.id_peminjaman, p.nama, p.alamat, p.tanggal_peminjaman, p.id_alat, p.id_kamera,
                   k.harga AS harga
            FROM peminjaman p
            LEFT JOIN kamera k ON p.id_kamera = k.tipe_kamera";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Peminjaman peminjaman = new Peminjaman();
                        // Asumsikan Peminjaman memiliki properti: Id, Nama, Alamat, TanggalPeminjaman, IdAlat, IdKamera
                        // Sesuaikan properti berikut ini dengan struktur objek Peminjaman Anda
                        peminjaman.Id = Convert.ToInt32(reader["id_peminjaman"]);
                        peminjaman.Nama = Convert.ToString(reader["nama"]);
                        peminjaman.Alamat = Convert.ToString(reader["alamat"]);
                        peminjaman.TanggalPeminjaman = Convert.ToDateTime(reader["tanggal_peminjaman"]);
                        peminjaman.Alat = Convert.ToString(reader["id_alat"]);
                        peminjaman.Kamera = Convert.ToString(reader["id_kamera"]);
                        // Anda perlu memutuskan bagaimana menggunakan objek Kamera ini
                        Kamera kamera = new Kamera();
                        kamera.harga = reader.IsDBNull(reader.GetOrdinal("harga"))
                                       ? "0"
                                       : Convert.ToString(reader["harga"]);

                        // Misalnya, jika ada properti HargaKamera di Peminjaman
                        peminjaman.Harga = kamera.harga;
                        listPeminjaman.Add(peminjaman);
                    }
                }
            }
        }
        catch (Exception err)
        {
            System.Diagnostics.Debug.Print(err.Message);
        }

        return listPeminjaman;
    }
    public int Deletepeminjaan(int id)
    {
        int result = 0;
        string sql = "DELETE FROM peminjaman WHERE id_peminjaman = @id";

        using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
        {
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }
        }

        return result;
    }
    public int UpdatePeminjaman(Peminjaman pinjam)
    {
        int result = 0;
        string sql = "UPDATE peminjaman SET nama = @nama, alamat = @alamat, tanggal_peminjaman = @tanggal, id_alat = @alat, id_kamera = @kamera WHERE id_peminjaman = @id";

        using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
        {
            // Sesuaikan nama parameter dengan nama kolom di database
            cmd.Parameters.AddWithValue("@nama", pinjam.Nama);
            cmd.Parameters.AddWithValue("@alamat", pinjam.Alamat);
            cmd.Parameters.AddWithValue("@tanggal", pinjam.TanggalPeminjaman);
            cmd.Parameters.AddWithValue("@alat", pinjam.Alat);
            cmd.Parameters.AddWithValue("@kamera", pinjam.Kamera);
            cmd.Parameters.AddWithValue("@id", pinjam.Id);

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }
        }

        return result;
    }
    public int UpdAlat(Peminjaman pinjam)
    {
        int result = 0;

        using (DbContext connect = new DbContext())
        {
            this._repository = new PeminjamanRepository(connect);
            result = this._repository.UpdatePeminjaman(pinjam);
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
}
