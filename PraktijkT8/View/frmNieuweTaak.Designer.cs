namespace PraktijkT8.View
{
    partial class frmNieuweTaak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitel = new Label();
            lblNaam = new Label();
            tbNaam = new TextBox();
            lblOmschrijving = new Label();
            tbOmschrijving = new TextBox();
            lblStartDatum = new Label();
            lblInleverdatum = new Label();
            dtpStartDatum = new DateTimePicker();
            dtpInleverdatum = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnOpslaan = new Button();
            btnAnnuleren = new Button();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitel.Location = new Point(30, 20);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(283, 32);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Nieuwe taak toevoegen";
            // 
            // lblNaam
            // 
            lblNaam.AutoSize = true;
            lblNaam.Location = new Point(30, 80);
            lblNaam.Name = "lblNaam";
            lblNaam.Size = new Size(39, 15);
            lblNaam.TabIndex = 1;
            lblNaam.Text = "Naam";
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(150, 75);
            tbNaam.Multiline = true;
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(250, 25);
            tbNaam.TabIndex = 2;
            // 
            // lblOmschrijving
            // 
            lblOmschrijving.AutoSize = true;
            lblOmschrijving.Location = new Point(30, 120);
            lblOmschrijving.Name = "lblOmschrijving";
            lblOmschrijving.Size = new Size(78, 15);
            lblOmschrijving.TabIndex = 3;
            lblOmschrijving.Text = "Omschrijving";
            // 
            // tbOmschrijving
            // 
            tbOmschrijving.Location = new Point(150, 115);
            tbOmschrijving.Multiline = true;
            tbOmschrijving.Name = "tbOmschrijving";
            tbOmschrijving.Size = new Size(250, 70);
            tbOmschrijving.TabIndex = 4;
            // 
            // lblStartDatum
            // 
            lblStartDatum.AutoSize = true;
            lblStartDatum.Location = new Point(30, 210);
            lblStartDatum.Name = "lblStartDatum";
            lblStartDatum.Size = new Size(67, 15);
            lblStartDatum.TabIndex = 5;
            lblStartDatum.Text = "StartDatum";
            // 
            // lblInleverdatum
            // 
            lblInleverdatum.AutoSize = true;
            lblInleverdatum.Location = new Point(30, 250);
            lblInleverdatum.Name = "lblInleverdatum";
            lblInleverdatum.Size = new Size(77, 15);
            lblInleverdatum.TabIndex = 6;
            lblInleverdatum.Text = "Inleverdatum";
            // 
            // dtpStartDatum
            // 
            dtpStartDatum.Location = new Point(150, 205);
            dtpStartDatum.Name = "dtpStartDatum";
            dtpStartDatum.Size = new Size(250, 23);
            dtpStartDatum.TabIndex = 7;
            // 
            // dtpInleverdatum
            // 
            dtpInleverdatum.Location = new Point(150, 245);
            dtpInleverdatum.Name = "dtpInleverdatum";
            dtpInleverdatum.Size = new Size(200, 23);
            dtpInleverdatum.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 290);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Open", "Bezig", "Afgerond" });
            cmbStatus.Location = new Point(150, 285);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 23);
            cmbStatus.TabIndex = 10;
            // 
            // btnOpslaan
            // 
            btnOpslaan.BackColor = Color.White;
            btnOpslaan.FlatStyle = FlatStyle.Flat;
            btnOpslaan.ForeColor = Color.Black;
            btnOpslaan.Location = new Point(150, 340);
            btnOpslaan.Name = "btnOpslaan";
            btnOpslaan.Size = new Size(110, 35);
            btnOpslaan.TabIndex = 11;
            btnOpslaan.Text = "Opslaan";
            btnOpslaan.UseVisualStyleBackColor = false;
            btnOpslaan.Click += btnOpslaan_Click;
            // 
            // btnAnnuleren
            // 
            btnAnnuleren.BackColor = Color.White;
            btnAnnuleren.FlatStyle = FlatStyle.Flat;
            btnAnnuleren.ForeColor = Color.Black;
            btnAnnuleren.Location = new Point(290, 340);
            btnAnnuleren.Name = "btnAnnuleren";
            btnAnnuleren.Size = new Size(110, 35);
            btnAnnuleren.TabIndex = 12;
            btnAnnuleren.Text = "Annuleren";
            btnAnnuleren.UseVisualStyleBackColor = false;
            // 
            // frmNieuweTaak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(484, 411);
            Controls.Add(btnAnnuleren);
            Controls.Add(btnOpslaan);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpInleverdatum);
            Controls.Add(dtpStartDatum);
            Controls.Add(lblInleverdatum);
            Controls.Add(lblStartDatum);
            Controls.Add(tbOmschrijving);
            Controls.Add(lblOmschrijving);
            Controls.Add(tbNaam);
            Controls.Add(lblNaam);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNieuweTaak";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NieuweTaak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblNaam;
        private TextBox tbNaam;
        private Label lblOmschrijving;
        private TextBox tbOmschrijving;
        private Label lblStartDatum;
        private Label lblInleverdatum;
        private DateTimePicker dtpStartDatum;
        private DateTimePicker dtpInleverdatum;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnOpslaan;
        private Button btnAnnuleren;
    }
}