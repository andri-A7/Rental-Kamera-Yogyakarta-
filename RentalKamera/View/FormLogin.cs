using RentalKamera.Controller;
using RentalKamera.Model.Context;
using RentalKamera.Model.Entity;
using System.Threading;
using System.Windows.Forms;

namespace RentalKamera.View
{
    public partial class FormLogin : Form
    {
        private User user;
        private UserController controller;

        public FormLogin()
        {
            DbContext _connection = new DbContext();
            this.controller = new UserController(_connection);
            this.user = new User();

            InitializeComponent();

            this.username.Text = "admin";
            this.password.Text = "admin";
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            this.user.username = this.username.Text;
            this.user.password = this.password.Text;

            if (this.controller.login(user) != 0)
            {
                Thread thread;
                this.Close();
                thread = new Thread(this.SetOpenForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void SetOpenForm() => Application.Run(new FormRentalKamera());

        private void FormLogin_Load(object sender, System.EventArgs e)
        {

        }
    }
}
