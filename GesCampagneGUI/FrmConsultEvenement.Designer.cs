namespace GesCampagneGUI
{
    partial class FrmConsultEvenement
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
            this.dtgConsultEvenement = new System.Windows.Forms.DataGridView();
            this.pnlPeriode = new System.Windows.Forms.Panel();
            this.lblPeriodeFin = new System.Windows.Forms.Label();
            this.lblPeriodeDebut = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.pnlChoixVille = new System.Windows.Forms.Panel();
            this.cbxChoixVille = new System.Windows.Forms.ComboBox();
            this.lblChoixVille = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEvenement)).BeginInit();
            this.pnlPeriode.SuspendLayout();
            this.pnlChoixVille.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultEvenement
            // 
            this.dtgConsultEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultEvenement.Location = new System.Drawing.Point(70, 161);
            this.dtgConsultEvenement.Name = "dtgConsultEvenement";
            this.dtgConsultEvenement.Size = new System.Drawing.Size(657, 213);
            this.dtgConsultEvenement.TabIndex = 0;
            // 
            // pnlPeriode
            // 
            this.pnlPeriode.Controls.Add(this.lblPeriodeFin);
            this.pnlPeriode.Controls.Add(this.lblPeriodeDebut);
            this.pnlPeriode.Controls.Add(this.dtpFin);
            this.pnlPeriode.Controls.Add(this.dtpDebut);
            this.pnlPeriode.Controls.Add(this.lblPeriode);
            this.pnlPeriode.Location = new System.Drawing.Point(70, 4);
            this.pnlPeriode.Name = "pnlPeriode";
            this.pnlPeriode.Size = new System.Drawing.Size(595, 82);
            this.pnlPeriode.TabIndex = 1;
            // 
            // lblPeriodeFin
            // 
            this.lblPeriodeFin.AutoSize = true;
            this.lblPeriodeFin.Location = new System.Drawing.Point(40, 59);
            this.lblPeriodeFin.Name = "lblPeriodeFin";
            this.lblPeriodeFin.Size = new System.Drawing.Size(47, 13);
            this.lblPeriodeFin.TabIndex = 4;
            this.lblPeriodeFin.Text = "Date fin:";
            // 
            // lblPeriodeDebut
            // 
            this.lblPeriodeDebut.AutoSize = true;
            this.lblPeriodeDebut.Location = new System.Drawing.Point(37, 22);
            this.lblPeriodeDebut.Name = "lblPeriodeDebut";
            this.lblPeriodeDebut.Size = new System.Drawing.Size(63, 13);
            this.lblPeriodeDebut.TabIndex = 3;
            this.lblPeriodeDebut.Text = "Date début:";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(145, 53);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 2;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(145, 16);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 1;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(3, 5);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(76, 13);
            this.lblPeriode.TabIndex = 0;
            this.lblPeriode.Text = "Saisie période:";
            // 
            // pnlChoixVille
            // 
            this.pnlChoixVille.Controls.Add(this.cbxChoixVille);
            this.pnlChoixVille.Controls.Add(this.lblChoixVille);
            this.pnlChoixVille.Location = new System.Drawing.Point(70, 104);
            this.pnlChoixVille.Name = "pnlChoixVille";
            this.pnlChoixVille.Size = new System.Drawing.Size(374, 51);
            this.pnlChoixVille.TabIndex = 2;
            // 
            // cbxChoixVille
            // 
            this.cbxChoixVille.FormattingEnabled = true;
            this.cbxChoixVille.Location = new System.Drawing.Point(100, 16);
            this.cbxChoixVille.Name = "cbxChoixVille";
            this.cbxChoixVille.Size = new System.Drawing.Size(179, 21);
            this.cbxChoixVille.TabIndex = 1;
            // 
            // lblChoixVille
            // 
            this.lblChoixVille.AutoSize = true;
            this.lblChoixVille.Location = new System.Drawing.Point(13, 16);
            this.lblChoixVille.Name = "lblChoixVille";
            this.lblChoixVille.Size = new System.Drawing.Size(58, 13);
            this.lblChoixVille.TabIndex = 0;
            this.lblChoixVille.Text = "Choix Ville:";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(515, 115);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(150, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // FrmConsultEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.pnlChoixVille);
            this.Controls.Add(this.pnlPeriode);
            this.Controls.Add(this.dtgConsultEvenement);
            this.Name = "FrmConsultEvenement";
            this.Text = "FrmConsultEvenement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEvenement)).EndInit();
            this.pnlPeriode.ResumeLayout(false);
            this.pnlPeriode.PerformLayout();
            this.pnlChoixVille.ResumeLayout(false);
            this.pnlChoixVille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultEvenement;
        private System.Windows.Forms.Panel pnlPeriode;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Panel pnlChoixVille;
        private System.Windows.Forms.Label lblChoixVille;
        private System.Windows.Forms.ComboBox cbxChoixVille;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lblPeriodeFin;
        private System.Windows.Forms.Label lblPeriodeDebut;
        private System.Windows.Forms.Button btnRechercher;
    }
}