using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PraktijkT8.Controller;
using System.IO;

namespace PraktijkT8.View
{
    public partial class frmModules : Form
    {
        private int themaID;

        private ModuleController controller =
        new ModuleController();

        public frmModules(int themaID)
        {
            InitializeComponent();
            this.themaID = themaID;

            ModulesLaden();
        }

        /// <summary>
        /// zorgt dat de datagridview wordt gevuld met de modules die bij het opgegeven themaID horen, 
        /// en verbergt de kolommen ModuleID, ThemaID en DocentID voor een betere gebruikerservaring
        /// </summary>
        private void ModulesLaden()
        {
            dgvModules.DataSource =
            controller.GetModules(themaID);

            dgvModules.Columns["ModuleID"].Visible = false;
            dgvModules.Columns["ThemaID"].Visible = false;
            dgvModules.Columns["DocentID"].Visible = false;
        }

        private void btnTaken_Click(object sender, EventArgs e)
        {
            if (dgvModules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een module.");
                return;
            }

            int moduleID = Convert.ToInt32(
                dgvModules.SelectedRows[0]
                .Cells["ModuleID"].Value);

            frmTaken form = new frmTaken(moduleID);

            form.ShowDialog();
        }

        /// <summary>
        /// haalt de naam van de afbeelding op uit de geselecteerde rij in de datagridview, bouwt het pad naar de afbeelding op en probeert deze te laden in een picturebox. 
        /// Als de afbeelding niet gevonden wordt, wordt er een foutmelding weergegeven en wordt de picturebox geleegd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count == 0)
            {
                return;
            }

            string afbeeldingNaam =
                dgvModules.SelectedRows[0].Cells["Afbeelding"].Value.ToString();

            string pad =
                Path.Combine(Application.StartupPath, "Images", afbeeldingNaam);

            if (File.Exists(pad))
            {
                picDocent.Image = Image.FromFile(pad);
            }
            else
            {
                picDocent.Image = null;
                MessageBox.Show("Afbeelding niet gevonden: " + pad);
            }
        }

        /// <summary>
        /// zorgt ervoor dat de geselecteerde module en alle bijbehorende taken worden verwijderd uit de database en dat de datagridview wordt bijgewerkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (dgvModules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een module.");
                return;
            }

            int moduleID = Convert.ToInt32(
                dgvModules.SelectedRows[0]
                .Cells["ModuleID"].Value);

            controller.VerwijderModule(moduleID);

            ModulesLaden();

            MessageBox.Show("Module verwijderd.");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
