using MySql.Data.MySqlClient;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace RentalKamera.Model.Repository
{
    public class PengembalianRepository
    {
        SQLiteConnection _connection;

        public PengembalianRepository(DbContext connection)
        {
            _connection = connection.Conn;
        }
        public int AddPengembalian(Pengembalian kembali)
        {
            int result = 0;
            string sql = "INSERT INTO pengembalian (nama, alamat, tanggal_peminjaman, tanggal_pengembalian, total_pembayaran, tipe_kamera, seri_alat) VALUES (@nama, @alamat, @tanggal_peminjaman, @tanggal_pengembalian, @total_pembayaran, @kamera, @alat)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@nama", kembali.Nama);
                cmd.Parameters.AddWithValue("@alamat", kembali.Alamat);
                cmd.Parameters.AddWithValue("@tanggal_peminjaman", kembali.TanggalPeminjaman);
                cmd.Parameters.AddWithValue("@tanggal_pengembalian", kembali.TanggalPengembalian);
                cmd.Parameters.AddWithValue("@total_pembayaran", kembali.Total);
                cmd.Parameters.AddWithValue("@kamera", kembali.Kamera); // Pastikan ini sesuai dengan tipe_kamera
                cmd.Parameters.AddWithValue("@alat", kembali.Alat);

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

        public List<Pengembalian> GetAllLaporan1()
        {
            List<Pengembalian> listPengembalian = new List<Pengembalian>();

            try
            {
                string sql = "SELECT id_pengembalian, nama, alamat, tanggal_peminjaman, tanggal_pengembalian,total_pembayaran, tipe_kamera, seri_alat FROM pengembalian";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pengembalian pengembalian = new Pengembalian();

                            // Asumsi bahwa kelas Pengembalian memiliki properti sesuai dengan kode ini.
                            // Sesuaikan dengan struktur kelas Pengembalian Anda.
                            pengembalian.Id = Convert.ToInt32(reader["id_pengembalian"]);
                            pengembalian.Nama = Convert.ToString(reader["nama"]);
                            pengembalian.Alamat = Convert.ToString(reader["alamat"]);
                            pengembalian.TanggalPeminjaman = Convert.ToDateTime(reader["tanggal_peminjaman"]);
                            pengembalian.TanggalPengembalian = Convert.ToDateTime(reader["tanggal_pengembalian"]);
                            pengembalian.Total = Convert.ToDecimal(reader["total_pembayaran"]).ToString();
                            pengembalian.Alat = Convert.ToString(reader["tipe_kamera"]);
                            pengembalian.Kamera = Convert.ToString(reader["seri_alat"]);

                            listPengembalian.Add(pengembalian);
                       }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return listPengembalian;
        }

        public List<Pengembalian> searchbyid(int id)
        {
            List<Pengembalian> listPeminjaman = new List<Pengembalian>();
            Pengembalian peminjaman = new Pengembalian();
            try
            {
                string sql = "SELECT \r\n    (julianday(tanggal_pengembalian) - julianday(tanggal_peminjaman)) AS hari_peminjaman,\r\n    total_pembayaran \r\nFROM pengembalian \r\nWHERE id_pengembalian = @id\r\n";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            peminjaman.HariPeminjaman = Convert.ToInt32(reader["hari_peminjaman"]);
                            peminjaman.Total = Convert.ToInt32(reader["total_pembayaran"]).ToString();

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
    }
}
