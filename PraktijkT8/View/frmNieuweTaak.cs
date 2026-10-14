using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PraktijkT8.Controller;
using PraktijkT8.Model;

namespace PraktijkT8.View
{
    public partial class frmNieuweTaak : Form
    {
        private int moduleID;

        private TaakController controller =
            new TaakController();

        public frmNieuweTaak()
        {
            InitializeComponent();
        }

        public frmNieuweTaak(int moduleID)
        {
            InitializeComponent();

            this.moduleID = moduleID;

            cmbStatus.SelectedIndex = 0;
        }

        /// <summary>
        /// zorgt ervoor dat er een nieuwe taak word toegevoegd aan de database en sluit het formulier daarna af
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            TaakModel taak =
       new TaakModel();

            taak.Naam =
                tbNaam.Text;

            taak.Omschrijving =
                tbOmschrijving.Text;

            taak.StartDatum =
                dtpStartDatum.Value;

            taak.Inleverdatum =
                dtpInleverdatum.Value;

            taak.Status =
                cmbStatus.Text;

            taak.ModuleID =
                moduleID;

            controller.VoegTaak(taak);

            MessageBox.Show("Taak toegevoegd.");

            this.Close();
        }
    }
}
