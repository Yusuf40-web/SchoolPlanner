namespace PraktijkT8.View
{
    partial class frmModules
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
            lblModules = new Label();
            lblZoekTb = new Label();
            tbZoeken = new TextBox();
            dgvModules = new DataGridView();
            pnlActies = new Panel();
            btnTerug = new Button();
            btnTaken = new Button();
            btnVerwijderen = new Button();
            picDocent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvModules).BeginInit();
            pnlActies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDocent).BeginInit();
            SuspendLayout();
            // 
            // lblModules
            // 
            lblModules.AutoSize = true;
            lblModules.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblModules.Location = new Point(40, 20);
            lblModules.Name = "lblModules";
            lblModules.Size = new Size(150, 45);
            lblModules.TabIndex = 0;
            lblModules.Text = "Modules";
            // 
            // lblZoekTb
            // 
            lblZoekTb.AutoSize = true;
            lblZoekTb.Location = new Point(40, 90);
            lblZoekTb.Name = "lblZoekTb";
            lblZoekTb.Size = new Size(85, 15);
            lblZoekTb.TabIndex = 1;
            lblZoekTb.Text = "Zoek op Naam";
            // 
            // tbZoeken
            // 
            tbZoeken.Location = new Point(40, 115);
            tbZoeken.Name = "tbZoeken";
            tbZoeken.Size = new Size(220, 23);
            tbZoeken.TabIndex = 2;
            // 
            // dgvModules
            // 
            dgvModules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModules.Location = new Point(40, 180);
            dgvModules.MultiSelect = false;
            dgvModules.Name = "dgvModules";
            dgvModules.ReadOnly = true;
            dgvModules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModules.Size = new Size(600, 350);
            dgvModules.TabIndex = 3;
            dgvModules.CellClick += dgvModules_CellClick;
            // 
            // pnlActies
            // 
            pnlActies.BackColor = Color.FromArgb(45, 80, 120);
            pnlActies.Controls.Add(btnTerug);
            pnlActies.Controls.Add(btnTaken);
            pnlActies.Controls.Add(btnVerwijderen);
            pnlActies.Location = new Point(784, 250);
            pnlActies.Name = "pnlActies";
            pnlActies.Size = new Size(170, 280);
            pnlActies.TabIndex = 4;
            // 
            // btnTerug
            // 
            btnTerug.BackColor = Color.White;
            btnTerug.FlatStyle = FlatStyle.Flat;
            btnTerug.ForeColor = Color.Black;
            btnTerug.Location = new Point(25, 212);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(120, 35);
            btnTerug.TabIndex = 4;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = false;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = Color.White;
            btnTaken.FlatStyle = FlatStyle.Flat;
            btnTaken.ForeColor = Color.Black;
            btnTaken.Location = new Point(25, 96);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(120, 35);
            btnTaken.TabIndex = 3;
            btnTaken.Text = "Taken bekijken";
            btnTaken.UseVisualStyleBackColor = false;
            btnTaken.Click += btnTaken_Click;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.BackColor = Color.White;
            btnVerwijderen.FlatStyle = FlatStyle.Flat;
            btnVerwijderen.ForeColor = Color.Black;
            btnVerwijderen.Location = new Point(25, 33);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(120, 35);
            btnVerwijderen.TabIndex = 2;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = false;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // picDocent
            // 
            picDocent.BackColor = Color.White;
            picDocent.BorderStyle = BorderStyle.FixedSingle;
            picDocent.Location = new Point(646, 20);
            picDocent.Name = "picDocent";
            picDocent.Size = new Size(200, 200);
            picDocent.SizeMode = PictureBoxSizeMode.Zoom;
            picDocent.TabIndex = 5;
            picDocent.TabStop = false;
            // 
            // frmModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(picDocent);
            Controls.Add(pnlActies);
            Controls.Add(dgvModules);
            Controls.Add(tbZoeken);
            Controls.Add(lblZoekTb);
            Controls.Add(lblModules);
            Name = "frmModules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModules";
            ((System.ComponentModel.ISupportInitialize)dgvModules).EndInit();
            pnlActies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDocent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModules;
        private Label lblZoekTb;
        private TextBox tbZoeken;
        private DataGridView dgvModules;
        private Panel pnlActies;
        private Button btnVerwijderen;
        private Button btnTaken;
        private Button btnTerug;
        private PictureBox picDocent;
    }
}