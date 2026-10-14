using System;
using System.Windows.Forms;
using PraktijkT8.Controller;

namespace PraktijkT8.View
{
    public partial class FrmThemas : Form
    {
        private ThemaController controller = new ThemaController();

        public FrmThemas()
        {
            InitializeComponent();
            LaadThemas();
        }

        private void LaadThemas()
        {
            dgvThemas.DataSource = controller.HaalAlleThemasOp();

            dgvThemas.Columns["ThemaID"].Visible = false;
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (dgvThemas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een thema.");
                return;
            }

            int themaID =
                Convert.ToInt32(
                    dgvThemas.SelectedRows[0]
                    .Cells["ThemaID"].Value);

            frmModules form =
                new frmModules(themaID);

            form.ShowDialog();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}