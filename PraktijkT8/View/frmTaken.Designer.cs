namespace PraktijkT8.View
{
    partial class frmTaken
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
            lblTaken = new Label();
            lblZoeken = new Label();
            tbZoeken = new TextBox();
            lblFilter = new Label();
            cmbStatus = new ComboBox();
            dgvTaken = new DataGridView();
            pnlActies = new Panel();
            btnVerwijderen = new Button();
            btnTerug = new Button();
            btnExportCsv = new Button();
            btnNieuw = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaken).BeginInit();
            pnlActies.SuspendLayout();
            SuspendLayout();
            // 
            // lblTaken
            // 
            lblTaken.AutoSize = true;
            lblTaken.BackColor = Color.Transparent;
            lblTaken.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTaken.Location = new Point(40, 20);
            lblTaken.Name = "lblTaken";
            lblTaken.Size = new Size(107, 45);
            lblTaken.TabIndex = 0;
            lblTaken.Text = "Taken";
            // 
            // lblZoeken
            // 
            lblZoeken.AutoSize = true;
            lblZoeken.Location = new Point(40, 90);
            lblZoeken.Name = "lblZoeken";
            lblZoeken.Size = new Size(83, 15);
            lblZoeken.TabIndex = 1;
            lblZoeken.Text = "Zoek op naam";
            // 
            // tbZoeken
            // 
            tbZoeken.Location = new Point(40, 115);
            tbZoeken.Name = "tbZoeken";
            tbZoeken.Size = new Size(220, 23);
            tbZoeken.TabIndex = 2;
            tbZoeken.TextChanged += tbZoeken_TextChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(280, 90);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(85, 15);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Filter op Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Alle", "Open", "Bezig", "Afgerond" });
            cmbStatus.Location = new Point(280, 115);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 23);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dgvTaken
            // 
            dgvTaken.AllowUserToAddRows = false;
            dgvTaken.AllowUserToDeleteRows = false;
            dgvTaken.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaken.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaken.Location = new Point(40, 160);
            dgvTaken.MultiSelect = false;
            dgvTaken.Name = "dgvTaken";
            dgvTaken.ReadOnly = true;
            dgvTaken.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaken.Size = new Size(570, 260);
            dgvTaken.TabIndex = 5;
            // 
            // pnlActies
            // 
            pnlActies.BackColor = Color.FromArgb(45, 80, 120);
            pnlActies.Controls.Add(btnVerwijderen);
            pnlActies.Controls.Add(btnTerug);
            pnlActies.Controls.Add(btnExportCsv);
            pnlActies.Controls.Add(btnNieuw);
            pnlActies.Location = new Point(640, 160);
            pnlActies.Name = "pnlActies";
            pnlActies.Size = new Size(170, 260);
            pnlActies.TabIndex = 6;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.BackColor = Color.White;
            btnVerwijderen.FlatStyle = FlatStyle.Flat;
            btnVerwijderen.ForeColor = Color.Black;
            btnVerwijderen.Location = new Point(25, 70);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(120, 35);
            btnVerwijderen.TabIndex = 3;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = false;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // btnTerug
            // 
            btnTerug.BackColor = Color.White;
            btnTerug.FlatStyle = FlatStyle.Flat;
            btnTerug.ForeColor = Color.Black;
            btnTerug.Location = new Point(25, 190);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(120, 35);
            btnTerug.TabIndex = 2;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = false;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.White;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.ForeColor = Color.Black;
            btnExportCsv.Location = new Point(25, 120);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(120, 35);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnNieuw
            // 
            btnNieuw.BackColor = Color.White;
            btnNieuw.FlatStyle = FlatStyle.Flat;
            btnNieuw.ForeColor = Color.Black;
            btnNieuw.Location = new Point(25, 20);
            btnNieuw.Name = "btnNieuw";
            btnNieuw.Size = new Size(120, 35);
            btnNieuw.TabIndex = 0;
            btnNieuw.Text = "Nieuw";
            btnNieuw.UseVisualStyleBackColor = false;
            btnNieuw.Click += btnNieuw_Click;
            // 
            // frmTaken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(834, 461);
            Controls.Add(pnlActies);
            Controls.Add(dgvTaken);
            Controls.Add(cmbStatus);
            Controls.Add(lblFilter);
            Controls.Add(tbZoeken);
            Controls.Add(lblZoeken);
            Controls.Add(lblTaken);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmTaken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taken";
            ((System.ComponentModel.ISupportInitialize)dgvTaken).EndInit();
            pnlActies.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaken;
        private Label lblZoeken;
        private TextBox tbZoeken;
        private Label lblFilter;
        private ComboBox cmbStatus;
        private DataGridView dgvTaken;
        private Panel pnlActies;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnNieuw;
        private Button btnVerwijderen;
        private Button btnTerug;
        private Button btnExportCsv;
    }
}