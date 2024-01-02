using System.Windows.Forms;

namespace RentalKamera.View
{
    public partial class FormRentalKamera : Form
    {
        public FormRentalKamera()
        {
            InitializeComponent();
        }

        private void btnKamera_Click(object sender, System.EventArgs e)
        {
            FormKamera form = new FormKamera();
            form.ShowDialog();
        }

        private void btnAlatPelengkapanKamera_Click(object sender, System.EventArgs e)
        {
            FormAlatPerlengkapanKamera form = new FormAlatPerlengkapanKamera();
            form.ShowDialog();
        }

        private void btnPeminjaman_Click(object sender, System.EventArgs e)
        {
            FormPeminjaman form = new FormPeminjaman();
            form.ShowDialog();
        }

        private void btnPengembalian_Click(object sender, System.EventArgs e)
        {
            FormPengembalian form = new FormPengembalian();
            form.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FormLaporan form = new FormLaporan();
            form.ShowDialog();
        }
    }
}
