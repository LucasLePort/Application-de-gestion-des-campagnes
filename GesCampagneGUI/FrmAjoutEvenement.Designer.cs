namespace GesCampagneGUI
{
    partial class FrmAjoutEvenement
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.cbxEvenementiel = new System.Windows.Forms.ComboBox();
            this.lblEvenementiel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(261, 50);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(46, 13);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Thème :";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(261, 114);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Libelle :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(261, 291);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(66, 13);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(261, 352);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(50, 13);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date fin :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(403, 345);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 4;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(403, 284);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 5;
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(403, 394);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(75, 23);
            this.btnEnreg.TabIndex = 6;
            this.btnEnreg.Text = "Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(403, 114);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(200, 20);
            this.txtLibelle.TabIndex = 7;
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(403, 50);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(200, 20);
            this.txtTheme.TabIndex = 8;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(261, 180);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville :";
            // 
            // cbxVille
            // 
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(403, 180);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(200, 21);
            this.cbxVille.TabIndex = 11;
            // 
            // cbxEvenementiel
            // 
            this.cbxEvenementiel.FormattingEnabled = true;
            this.cbxEvenementiel.Location = new System.Drawing.Point(403, 235);
            this.cbxEvenementiel.Name = "cbxEvenementiel";
            this.cbxEvenementiel.Size = new System.Drawing.Size(200, 21);
            this.cbxEvenementiel.TabIndex = 12;
            // 
            // lblEvenementiel
            // 
            this.lblEvenementiel.AutoSize = true;
            this.lblEvenementiel.Location = new System.Drawing.Point(264, 235);
            this.lblEvenementiel.Name = "lblEvenementiel";
            this.lblEvenementiel.Size = new System.Drawing.Size(77, 13);
            this.lblEvenementiel.TabIndex = 13;
            this.lblEvenementiel.Text = "Evenementiel :";
            // 
            // FrmAjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEvenementiel);
            this.Controls.Add(this.cbxEvenementiel);
            this.Controls.Add(this.cbxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblTheme);
            this.Name = "FrmAjoutEvenement";
            this.Text = "Ajout d\'un événement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.ComboBox cbxEvenementiel;
        private System.Windows.Forms.Label lblEvenementiel;
    }
}