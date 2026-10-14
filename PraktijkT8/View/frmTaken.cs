using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PraktijkT8.Controller;

namespace PraktijkT8.View
{
    public partial class frmTaken : Form
    {
        private int moduleID;

        private TaakController controller =
            new TaakController();

        public frmTaken(int moduleID)
        {
            InitializeComponent();

            this.moduleID = moduleID;

            cmbStatus.SelectedIndex = 0;

            TakenLaden();
        }
       
        private void TakenLaden()
        {
            dgvTaken.DataSource =
            controller.GetTaken(moduleID);

            dgvTaken.Columns["TaakID"].Visible = false;
            dgvTaken.Columns["ModuleID"].Visible = false;
        }
        /// <summary>
        /// zorgt ervoor dat de geselecteerde taak in de datagridview wordt verwijderd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (dgvTaken.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een taak.");
                return;
            }

            int taakID = Convert.ToInt32(
                dgvTaken.SelectedRows[0]
                .Cells["TaakID"].Value);

            controller.VerwijderTaak(taakID);

            TakenLaden();

            MessageBox.Show("Taak verwijderd.");
        }

        /// <summary>
        /// zorgt ervoor dat de taken in de datagridview worden gefilterd op basis van de geselecteerde status in de combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cmbStatus.SelectedItem.ToString();

            var taken = controller.GetTaken(moduleID);

            if (status != "Alle")                       //controleert of de status van de taken gelijk is aan de status van de gekozen status
            {
                taken = taken
                    .Where(t => t.Status == status)
                    .ToList();
            }

            dgvTaken.DataSource = taken;    

            dgvTaken.Columns["TaakID"].Visible = false;
            dgvTaken.Columns["ModuleID"].Visible = false;
        }

        /// <summary>
        /// zorgt ervoor dat de taken in de datagridview worden geëxporteerd naar een CSV-bestand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            StreamWriter writer =
        new StreamWriter("taken.csv");

            foreach (DataGridViewRow row in dgvTaken.Rows)
            {
                if (!row.IsNewRow)
                {
                    writer.WriteLine(
                        row.Cells["Naam"].Value + ";" +
                        row.Cells["Status"].Value);
                }
            }

            writer.Close();

            MessageBox.Show("CSV opgeslagen.");
        }

        /// <summary>
        /// regelt het zoeken van taken op naam in de datagridview. 
        /// De zoektekst wordt vergeleken met de naam van elke taak en alleen de taken die overeenkomen worden weergegeven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbZoeken_TextChanged(object sender, EventArgs e)
        {
            string zoektekst =      //Pakt wat de gebruiker typt.
            tbZoeken.Text.ToLower();

            var taken =                         //haalt alle taken op uit database
                controller.GetTaken(moduleID);

            taken = taken
                .Where(t =>
                    t.Naam.ToLower()
                    .Contains(zoektekst))
                .ToList();

            dgvTaken.DataSource = taken;

            dgvTaken.Columns["TaakID"].Visible = false;
            dgvTaken.Columns["ModuleID"].Visible = false;
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            frmNieuweTaak form =
            new frmNieuweTaak(moduleID);

            form.ShowDialog();

            TakenLaden();
        }
    }
}
