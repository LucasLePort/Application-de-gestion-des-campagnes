namespace GesCampagneGUI
{
    partial class FrmConsultCampagne
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
            this.dtgConsultCampagnes = new System.Windows.Forms.DataGridView();
            this.lblRechercheParNom = new System.Windows.Forms.Label();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.rbtRechercheNom = new System.Windows.Forms.RadioButton();
            this.rbtRecherchePeriode = new System.Windows.Forms.RadioButton();
            this.pnlRadioButton = new System.Windows.Forms.Panel();
            this.pnlRechercheNom = new System.Windows.Forms.Panel();
            this.pnlRecherchePeriode = new System.Windows.Forms.Panel();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebutPeriode = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFinPeriode = new System.Windows.Forms.DateTimePicker();
            this.btnRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultCampagnes)).BeginInit();
            this.pnlDataGrid.SuspendLayout();
            this.pnlRadioButton.SuspendLayout();
            this.pnlRechercheNom.SuspendLayout();
            this.pnlRecherchePeriode.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultCampagnes
            // 
            this.dtgConsultCampagnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultCampagnes.Location = new System.Drawing.Point(40, 35);
            this.dtgConsultCampagnes.Name = "dtgConsultCampagnes";
            this.dtgConsultCampagnes.Size = new System.Drawing.Size(722, 209);
            this.dtgConsultCampagnes.TabIndex = 0;
            // 
            // lblRechercheParNom
            // 
            this.lblRechercheParNom.AutoSize = true;
            this.lblRechercheParNom.Location = new System.Drawing.Point(34, 25);
            this.lblRechercheParNom.Name = "lblRechercheParNom";
            this.lblRechercheParNom.Size = new System.Drawing.Size(249, 13);
            this.lblRechercheParNom.TabIndex = 1;
            this.lblRechercheParNom.Text = "Rechercher une campagne en saisissant son nom :";
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Location = new System.Drawing.Point(327, 22);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(308, 20);
            this.txtRechercheNom.TabIndex = 2;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.dtgConsultCampagnes);
            this.pnlDataGrid.Location = new System.Drawing.Point(74, 291);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(789, 267);
            this.pnlDataGrid.TabIndex = 3;
            // 
            // rbtRechercheNom
            // 
            this.rbtRechercheNom.AutoSize = true;
            this.rbtRechercheNom.Location = new System.Drawing.Point(36, 21);
            this.rbtRechercheNom.Name = "rbtRechercheNom";
            this.rbtRechercheNom.Size = new System.Drawing.Size(230, 17);
            this.rbtRechercheNom.TabIndex = 5;
            this.rbtRechercheNom.TabStop = true;
            this.rbtRechercheNom.Text = "Recherche d\'une campagne avec son nom";
            this.rbtRechercheNom.UseVisualStyleBackColor = true;
            this.rbtRechercheNom.CheckedChanged += new System.EventHandler(this.rbtRechercheNom_CheckedChanged);
            // 
            // rbtRecherchePeriode
            // 
            this.rbtRecherchePeriode.AutoSize = true;
            this.rbtRecherchePeriode.Location = new System.Drawing.Point(385, 21);
            this.rbtRecherchePeriode.Name = "rbtRecherchePeriode";
            this.rbtRecherchePeriode.Size = new System.Drawing.Size(270, 17);
            this.rbtRecherchePeriode.TabIndex = 6;
            this.rbtRecherchePeriode.TabStop = true;
            this.rbtRecherchePeriode.Text = "Recherche des campagnes dans une période saisie";
            this.rbtRecherchePeriode.UseVisualStyleBackColor = true;
            this.rbtRecherchePeriode.CheckedChanged += new System.EventHandler(this.rbtRecherchePeriode_CheckedChanged);
            // 
            // pnlRadioButton
            // 
            this.pnlRadioButton.Controls.Add(this.rbtRecherchePeriode);
            this.pnlRadioButton.Controls.Add(this.rbtRechercheNom);
            this.pnlRadioButton.Location = new System.Drawing.Point(107, 28);
            this.pnlRadioButton.Name = "pnlRadioButton";
            this.pnlRadioButton.Size = new System.Drawing.Size(691, 56);
            this.pnlRadioButton.TabIndex = 7;
            // 
            // pnlRechercheNom
            // 
            this.pnlRechercheNom.Controls.Add(this.txtRechercheNom);
            this.pnlRechercheNom.Controls.Add(this.lblRechercheParNom);
            this.pnlRechercheNom.Location = new System.Drawing.Point(123, 90);
            this.pnlRechercheNom.Name = "pnlRechercheNom";
            this.pnlRechercheNom.Size = new System.Drawing.Size(656, 64);
            this.pnlRechercheNom.TabIndex = 8;
            // 
            // pnlRecherchePeriode
            // 
            this.pnlRecherchePeriode.Controls.Add(this.btnRecherche);
            this.pnlRecherchePeriode.Controls.Add(this.dtpDateFinPeriode);
            this.pnlRecherchePeriode.Controls.Add(this.dtpDateDebutPeriode);
            this.pnlRecherchePeriode.Controls.Add(this.lblDateFin);
            this.pnlRecherchePeriode.Controls.Add(this.lblDateDebut);
            this.pnlRecherchePeriode.Location = new System.Drawing.Point(84, 159);
            this.pnlRecherchePeriode.Name = "pnlRecherchePeriode";
            this.pnlRecherchePeriode.Size = new System.Drawing.Size(766, 112);
            this.pnlRecherchePeriode.TabIndex = 9;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(20, 16);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(180, 13);
            this.lblDateDebut.TabIndex = 9;
            this.lblDateDebut.Text = "Date de début de la période à saisir :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(36, 54);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(164, 13);
            this.lblDateFin.TabIndex = 10;
            this.lblDateFin.Text = "Date de fin de la période à saisir :";
            // 
            // dtpDateDebutPeriode
            // 
            this.dtpDateDebutPeriode.Location = new System.Drawing.Point(231, 16);
            this.dtpDateDebutPeriode.Name = "dtpDateDebutPeriode";
            this.dtpDateDebutPeriode.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebutPeriode.TabIndex = 11;
            // 
            // dtpDateFinPeriode
            // 
            this.dtpDateFinPeriode.Location = new System.Drawing.Point(231, 54);
            this.dtpDateFinPeriode.Name = "dtpDateFinPeriode";
            this.dtpDateFinPeriode.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinPeriode.TabIndex = 12;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(515, 27);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(159, 40);
            this.btnRecherche.TabIndex = 13;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // FrmConsultCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.pnlRecherchePeriode);
            this.Controls.Add(this.pnlRadioButton);
            this.Controls.Add(this.pnlRechercheNom);
            this.Controls.Add(this.pnlDataGrid);
            this.Name = "FrmConsultCampagne";
            this.Text = "Consultation des campagnes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultCampagnes)).EndInit();
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlRadioButton.ResumeLayout(false);
            this.pnlRadioButton.PerformLayout();
            this.pnlRechercheNom.ResumeLayout(false);
            this.pnlRechercheNom.PerformLayout();
            this.pnlRecherchePeriode.ResumeLayout(false);
            this.pnlRecherchePeriode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultCampagnes;
        private System.Windows.Forms.Label lblRechercheParNom;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.RadioButton rbtRechercheNom;
        private System.Windows.Forms.RadioButton rbtRecherchePeriode;
        private System.Windows.Forms.Panel pnlRadioButton;
        private System.Windows.Forms.Panel pnlRechercheNom;
        private System.Windows.Forms.Panel pnlRecherchePeriode;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.DateTimePicker dtpDateFinPeriode;
        private System.Windows.Forms.DateTimePicker dtpDateDebutPeriode;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
    }
}