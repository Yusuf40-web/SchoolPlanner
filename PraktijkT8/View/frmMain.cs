using PraktijkT8.View;

namespace PraktijkT8
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThemas_Click(object sender, EventArgs e)
        {
            FrmThemas form = new FrmThemas();
            form.ShowDialog();
        }

        private void btnThemas_Click_1(object sender, EventArgs e)
        {
            FrmThemas form = new FrmThemas();
            form.ShowDialog();
        }

        private void btnAflsuiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
