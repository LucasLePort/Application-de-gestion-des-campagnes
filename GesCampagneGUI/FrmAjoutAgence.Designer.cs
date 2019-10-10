namespace GesCampagneGUI
{
    partial class FrmAjoutAgence
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbAdresse = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.grbAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(195, 68);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(93, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom de l\'agence :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(6, 63);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // grbAdresse
            // 
            this.grbAdresse.Controls.Add(this.lblRue);
            this.grbAdresse.Controls.Add(this.lblVille);
            this.grbAdresse.Location = new System.Drawing.Point(198, 179);
            this.grbAdresse.Name = "grbAdresse";
            this.grbAdresse.Size = new System.Drawing.Size(342, 149);
            this.grbAdresse.TabIndex = 5;
            this.grbAdresse.TabStop = false;
            this.grbAdresse.Text = "Adresse";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(195, 125);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(72, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Adresse mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(195, 96);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(109, 13);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Numéro de téléphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Site internet :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(6, 31);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(27, 13);
            this.lblRue.TabIndex = 4;
            this.lblRue.Text = "Rue";
            // 
            // FrmAjoutAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.grbAdresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmAjoutAgence";
            this.Text = "Ajout d\'une agence";
            this.grbAdresse.ResumeLayout(false);
            this.grbAdresse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbAdresse;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label label1;
    }
}