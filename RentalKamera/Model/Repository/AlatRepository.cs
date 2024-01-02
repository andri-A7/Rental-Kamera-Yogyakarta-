using MySql.Data.MySqlClient;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RentalKamera.Model.Repository
{
    public class AlatRepository
    {
        SQLiteConnection _connection;
        public AlatRepository(DbContext connection)
        {
            _connection = connection.Conn;
        }

        public int addAlat(Alat alat)
        {
            int result = 0;

            string sql = "INSERT INTO alat (jenis_alat, seri_alat, jumlah_alat) VALUES (@jenis, @seri, @jumlah)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@jenis", alat.Jenis);
                cmd.Parameters.AddWithValue("@seri", alat.Seri);
                cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(alat.Jumlah));
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
        public List<Alat> GetAllAlat()
        {
            List<Alat> listAlat = new List<Alat>();

            try
            {
                string sql = "SELECT id_alat, jenis_alat, seri_alat, jumlah_alat FROM alat";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alat alat = new Alat();
                            alat.Id = reader["id_alat"].ToString();
                            alat.Jenis = reader["jenis_alat"].ToString();
                            alat.Seri = reader["seri_alat"].ToString();
                            alat.Jumlah = reader["jumlah_alat"].ToString();
                            listAlat.Add(alat);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return listAlat;
        }
        public List<Alat> GetAlat()
        {
            List<Alat> listalat = new List<Alat>();

            try
            {
                string sql = "SELECT seri_alat FROM alat";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alat alat = new Alat();
                            alat.Seri = reader["seri_alat"].ToString();
                            listalat.Add(alat);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return listalat;
        }
        public int UpdateAlat(Alat alat)
        {
            int result = 0;
            string sql = "UPDATE alat SET jenis_alat = @jenis, seri_alat = @seri, jumlah_alat = @jumlah WHERE id_alat = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@jenis", alat.Jenis);
                cmd.Parameters.AddWithValue("@seri", alat.Seri);
                cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(alat.Jumlah));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(alat.Id));

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
        public int DeleteAlat(int id)
        {
            int result = 0;
            string sql = "DELETE FROM alat WHERE id_alat = @id";

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

    }
}
