namespace PraktijkT8.View
{
    partial class FrmThemas
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
            tbZoeken = new TextBox();
            lblZoeken = new Label();
            dgvThemas = new DataGridView();
            pnlActies = new Panel();
            btnTerug = new Button();
            btnModules = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThemas).BeginInit();
            pnlActies.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.BackColor = Color.Transparent;
            lblTitel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitel.ForeColor = Color.Black;
            lblTitel.Location = new Point(30, 9);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(134, 41);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Thema's";
            // 
            // tbZoeken
            // 
            tbZoeken.Font = new Font("Segoe UI", 10F);
            tbZoeken.Location = new Point(30, 85);
            tbZoeken.Multiline = true;
            tbZoeken.Name = "tbZoeken";
            tbZoeken.Size = new Size(250, 28);
            tbZoeken.TabIndex = 1;
            // 
            // lblZoeken
            // 
            lblZoeken.AutoSize = true;
            lblZoeken.Location = new Point(30, 65);
            lblZoeken.Name = "lblZoeken";
            lblZoeken.Size = new Size(83, 15);
            lblZoeken.TabIndex = 2;
            lblZoeken.Text = "Zoek op naam";
            // 
            // dgvThemas
            // 
            dgvThemas.AllowUserToAddRows = false;
            dgvThemas.AllowUserToDeleteRows = false;
            dgvThemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThemas.BackgroundColor = Color.White;
            dgvThemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThemas.Location = new Point(30, 130);
            dgvThemas.MultiSelect = false;
            dgvThemas.Name = "dgvThemas";
            dgvThemas.ReadOnly = true;
            dgvThemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThemas.Size = new Size(520, 280);
            dgvThemas.TabIndex = 3;
            // 
            // pnlActies
            // 
            pnlActies.BackColor = Color.FromArgb(45, 80, 120);
            pnlActies.Controls.Add(btnTerug);
            pnlActies.Controls.Add(btnModules);
            pnlActies.Location = new Point(580, 130);
            pnlActies.Name = "pnlActies";
            pnlActies.Size = new Size(170, 280);
            pnlActies.TabIndex = 4;
            // 
            // btnTerug
            // 
            btnTerug.BackColor = Color.White;
            btnTerug.FlatStyle = FlatStyle.Flat;
            btnTerug.Font = new Font("Segoe UI", 10F);
            btnTerug.ForeColor = Color.Black;
            btnTerug.Location = new Point(20, 220);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(130, 35);
            btnTerug.TabIndex = 4;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = false;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnModules
            // 
            btnModules.BackColor = Color.White;
            btnModules.FlatStyle = FlatStyle.Flat;
            btnModules.Font = new Font("Segoe UI", 10F);
            btnModules.ForeColor = Color.Black;
            btnModules.Location = new Point(20, 49);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(130, 35);
            btnModules.TabIndex = 3;
            btnModules.Text = "Modules Bekijken";
            btnModules.UseVisualStyleBackColor = false;
            btnModules.Click += btnModules_Click;
            // 
            // FrmThemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlActies);
            Controls.Add(dgvThemas);
            Controls.Add(lblZoeken);
            Controls.Add(tbZoeken);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmThemas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thema's";
            ((System.ComponentModel.ISupportInitialize)dgvThemas).EndInit();
            pnlActies.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private TextBox tbZoeken;
        private Label lblZoeken;
        private DataGridView dgvThemas;
        private Panel pnlActies;
        private Button btnTerug;
        private Button btnModules;
    }
}