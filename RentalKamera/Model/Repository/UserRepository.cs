using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System;
using System.Data;
using System.Data.SQLite;
namespace RentalKamera.Model.Repository
{
    public class UserRepository
    {
        private SQLiteConnection _connect;
        public UserRepository(DbContext connection)
        {
            _connect = connection.Conn;
        }

        public int login(User user)
        {
            int result = 0;

            try
            {
                string sql = @"SELECT * FROM users WHERE username = @username AND password = @password";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _connect))
                {

                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@password", user.password);

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    result = datatable.Rows.Count;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return result;
        }
    }
}
