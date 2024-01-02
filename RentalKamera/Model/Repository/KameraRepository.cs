using MySql.Data.MySqlClient;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace RentalKamera.Model.Repository
{
    public class KameraRepository
    {
        SQLiteConnection _connection;

        public KameraRepository(DbContext connection)
        {
            _connection = connection.Conn;
        }

        public int addKamera(Kamera kamera)
        {
            int result = 0;

            string sql = "INSERT INTO kamera (id_kamera, merk_kamera, tipe_kamera, harga) VALUES (@id, @merk, @tipe, @harga)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@id", kamera.id);
                cmd.Parameters.AddWithValue("@merk", kamera.merk);
                cmd.Parameters.AddWithValue("@tipe", kamera.tipe);
                cmd.Parameters.AddWithValue("@harga", Convert.ToInt32(kamera.harga));
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

        public List<Kamera> GetAll()
        {
            List<Kamera> listKamera = new List<Kamera>();

            try
            {
                string sql = "SELECT id_kamera, merk_kamera, tipe_kamera, harga FROM kamera";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kamera kamera = new Kamera();
                            kamera.id = reader["id_kamera"].ToString();
                            kamera.merk = reader["merk_kamera"].ToString();
                            kamera.tipe = reader["tipe_kamera"].ToString();
                            kamera.harga = reader["harga"].ToString();
                            listKamera.Add(kamera);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return listKamera;
        }
        public List<Kamera> GetAllKameras()
        {
            List<Kamera> listKamera = new List<Kamera>();

            try
            {
                string sql = "SELECT tipe_kamera FROM kamera";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kamera kamera = new Kamera();
                            kamera.tipe = reader["tipe_kamera"].ToString();
                            listKamera.Add(kamera);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return listKamera;
        }
    }
}
