namespace GesCampagneGUI
{
    partial class FrmAjoutCampagne
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
            this.lblIntitule = new System.Windows.Forms.Label();
            this.lblObjectif = new System.Windows.Forms.Label();
            this.lblDebutCampagne = new System.Windows.Forms.Label();
            this.lblFinCampagne = new System.Windows.Forms.Label();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtObjectif = new System.Windows.Forms.TextBox();
            this.dtpDebutCampagne = new System.Windows.Forms.DateTimePicker();
            this.dtpFinCampagne = new System.Windows.Forms.DateTimePicker();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.lblCommunication = new System.Windows.Forms.Label();
            this.lblCategoriePublic = new System.Windows.Forms.Label();
            this.cbxEvenementiel = new System.Windows.Forms.ComboBox();
            this.cbxCommunication = new System.Windows.Forms.ComboBox();
            this.cbxCategPublic = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(245, 34);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(44, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitule :";
            // 
            // lblObjectif
            // 
            this.lblObjectif.AutoSize = true;
            this.lblObjectif.Location = new System.Drawing.Point(240, 74);
            this.lblObjectif.Name = "lblObjectif";
            this.lblObjectif.Size = new System.Drawing.Size(49, 13);
            this.lblObjectif.TabIndex = 1;
            this.lblObjectif.Text = "Objectif :";
            // 
            // lblDebutCampagne
            // 
            this.lblDebutCampagne.AutoSize = true;
            this.lblDebutCampagne.Location = new System.Drawing.Point(81, 114);
            this.lblDebutCampagne.Name = "lblDebutCampagne";
            this.lblDebutCampagne.Size = new System.Drawing.Size(208, 13);
            this.lblDebutCampagne.TabIndex = 2;
            this.lblDebutCampagne.Text = "Date du commencement de la campagne :";
            // 
            // lblFinCampagne
            // 
            this.lblFinCampagne.AutoSize = true;
            this.lblFinCampagne.Location = new System.Drawing.Point(145, 147);
            this.lblFinCampagne.Name = "lblFinCampagne";
            this.lblFinCampagne.Size = new System.Drawing.Size(144, 13);
            this.lblFinCampagne.TabIndex = 3;
            this.lblFinCampagne.Text = "Date de fin de la campagne :";
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(296, 34);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(200, 20);
            this.txtIntitule.TabIndex = 4;
            // 
            // txtObjectif
            // 
            this.txtObjectif.Location = new System.Drawing.Point(296, 66);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(200, 20);
            this.txtObjectif.TabIndex = 5;
            // 
            // dtpDebutCampagne
            // 
            this.dtpDebutCampagne.Location = new System.Drawing.Point(296, 114);
            this.dtpDebutCampagne.Name = "dtpDebutCampagne";
            this.dtpDebutCampagne.Size = new System.Drawing.Size(200, 20);
            this.dtpDebutCampagne.TabIndex = 6;
            // 
            // dtpFinCampagne
            // 
            this.dtpFinCampagne.Location = new System.Drawing.Point(296, 147);
            this.dtpFinCampagne.Name = "dtpFinCampagne";
            this.dtpFinCampagne.Size = new System.Drawing.Size(200, 20);
            this.dtpFinCampagne.TabIndex = 7;
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Location = new System.Drawing.Point(165, 192);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(124, 13);
            this.lblEvenement.TabIndex = 8;
            this.lblEvenement.Text = "Agence d\'évenementiel :";
            // 
            // lblCommunication
            // 
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Location = new System.Drawing.Point(150, 222);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(139, 13);
            this.lblCommunication.TabIndex = 9;
            this.lblCommunication.Text = "Agence de communication :";
            // 
            // lblCategoriePublic
            // 
            this.lblCategoriePublic.AutoSize = true;
            this.lblCategoriePublic.Location = new System.Drawing.Point(185, 258);
            this.lblCategoriePublic.Name = "lblCategoriePublic";
            this.lblCategoriePublic.Size = new System.Drawing.Size(104, 13);
            this.lblCategoriePublic.TabIndex = 10;
            this.lblCategoriePublic.Text = "Categorie du public :";
            // 
            // cbxEvenementiel
            // 
            this.cbxEvenementiel.FormattingEnabled = true;
            this.cbxEvenementiel.Location = new System.Drawing.Point(296, 192);
            this.cbxEvenementiel.Name = "cbxEvenementiel";
            this.cbxEvenementiel.Size = new System.Drawing.Size(200, 21);
            this.cbxEvenementiel.TabIndex = 11;
            // 
            // cbxCommunication
            // 
            this.cbxCommunication.FormattingEnabled = true;
            this.cbxCommunication.Location = new System.Drawing.Point(296, 222);
            this.cbxCommunication.Name = "cbxCommunication";
            this.cbxCommunication.Size = new System.Drawing.Size(200, 21);
            this.cbxCommunication.TabIndex = 12;
            // 
            // cbxCategPublic
            // 
            this.cbxCategPublic.FormattingEnabled = true;
            this.cbxCategPublic.Location = new System.Drawing.Point(296, 258);
            this.cbxCategPublic.Name = "cbxCategPublic";
            this.cbxCategPublic.Size = new System.Drawing.Size(200, 21);
            this.cbxCategPublic.TabIndex = 13;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(269, 315);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(134, 57);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 447);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxCategPublic);
            this.Controls.Add(this.cbxCommunication);
            this.Controls.Add(this.cbxEvenementiel);
            this.Controls.Add(this.lblCategoriePublic);
            this.Controls.Add(this.lblCommunication);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.dtpFinCampagne);
            this.Controls.Add(this.dtpDebutCampagne);
            this.Controls.Add(this.txtObjectif);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.lblFinCampagne);
            this.Controls.Add(this.lblDebutCampagne);
            this.Controls.Add(this.lblObjectif);
            this.Controls.Add(this.lblIntitule);
            this.Name = "FrmAjoutCampagne";
            this.Text = "Ajout d\'une campagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.Label lblObjectif;
        private System.Windows.Forms.Label lblDebutCampagne;
        private System.Windows.Forms.Label lblFinCampagne;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtObjectif;
        private System.Windows.Forms.DateTimePicker dtpDebutCampagne;
        private System.Windows.Forms.DateTimePicker dtpFinCampagne;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Label lblCategoriePublic;
        private System.Windows.Forms.ComboBox cbxEvenementiel;
        private System.Windows.Forms.ComboBox cbxCommunication;
        private System.Windows.Forms.ComboBox cbxCategPublic;
        private System.Windows.Forms.Button btnValider;
    }
}