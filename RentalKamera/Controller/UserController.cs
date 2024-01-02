using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using RentalKamera.Model.Repository;
using System.Windows.Forms;

namespace RentalKamera.Controller
{
    public class UserController
    {
        private DbContext connection;
        private UserRepository repository;

        public UserController(DbContext _connection)
        {
            connection = _connection;
            repository = new UserRepository(connection);
        }

        public int login(User user)
        {
            int result = 0;


            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password))
            {
                MessageBox.Show("Username atau Password Salah!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext connect = new DbContext())
            {
                result = repository.login(user);
            }

            if (result != 1)
            {
                MessageBox.Show("Username or Password Not Found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            return result;
        }
    }
}
