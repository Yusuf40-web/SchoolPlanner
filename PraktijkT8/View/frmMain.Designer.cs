namespace PraktijkT8
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelkom = new Label();
            pnlMenu = new Panel();
            btnAflsuiten = new Button();
            btnThemas = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelkom
            // 
            lblWelkom.AutoSize = true;
            lblWelkom.BackColor = Color.Transparent;
            lblWelkom.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelkom.Location = new Point(247, 25);
            lblWelkom.Name = "lblWelkom";
            lblWelkom.Size = new Size(457, 45);
            lblWelkom.TabIndex = 2;
            lblWelkom.Text = "Welkom bij de schoolplanner";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(45, 80, 120);
            pnlMenu.Controls.Add(btnAflsuiten);
            pnlMenu.Controls.Add(btnThemas);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(180, 511);
            pnlMenu.TabIndex = 3;
            // 
            // btnAflsuiten
            // 
            btnAflsuiten.FlatStyle = FlatStyle.Flat;
            btnAflsuiten.ForeColor = Color.White;
            btnAflsuiten.Location = new Point(20, 120);
            btnAflsuiten.Name = "btnAflsuiten";
            btnAflsuiten.Size = new Size(140, 40);
            btnAflsuiten.TabIndex = 5;
            btnAflsuiten.Text = "Afsluiten";
            btnAflsuiten.UseVisualStyleBackColor = true;
            btnAflsuiten.Click += btnAflsuiten_Click;
            // 
            // btnThemas
            // 
            btnThemas.BackColor = Color.FromArgb(45, 80, 120);
            btnThemas.FlatStyle = FlatStyle.Flat;
            btnThemas.ForeColor = Color.White;
            btnThemas.Location = new Point(20, 60);
            btnThemas.Name = "btnThemas";
            btnThemas.Size = new Size(140, 40);
            btnThemas.TabIndex = 4;
            btnThemas.Text = "Thema's";
            btnThemas.UseVisualStyleBackColor = false;
            btnThemas.Click += btnThemas_Click_1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 511);
            Controls.Add(pnlMenu);
            Controls.Add(lblWelkom);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolPlanner";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelkom;
        private Panel pnlMenu;
        private Button btnThemas;
        private Button btnAflsuiten;
    }
}
