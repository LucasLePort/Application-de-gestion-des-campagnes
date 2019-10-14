namespace GesCampagneGUI
{
    partial class FrmAjoutArtiste
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
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomArtiste = new System.Windows.Forms.TextBox();
            this.txt_siteArtiste = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cbxCourantArtiste = new System.Windows.Forms.ComboBox();
            this.lbl_Courant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Location = new System.Drawing.Point(27, 69);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(79, 13);
            this.lblNomArtiste.TabIndex = 0;
            this.lblNomArtiste.Text = "Nom de l\'artiste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site de l\'artiste";
            // 
            // txt_nomArtiste
            // 
            this.txt_nomArtiste.Location = new System.Drawing.Point(132, 66);
            this.txt_nomArtiste.Name = "txt_nomArtiste";
            this.txt_nomArtiste.Size = new System.Drawing.Size(100, 20);
            this.txt_nomArtiste.TabIndex = 2;
            // 
            // txt_siteArtiste
            // 
            this.txt_siteArtiste.Location = new System.Drawing.Point(132, 116);
            this.txt_siteArtiste.Name = "txt_siteArtiste";
            this.txt_siteArtiste.Size = new System.Drawing.Size(100, 20);
            this.txt_siteArtiste.TabIndex = 3;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(93, 295);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(111, 51);
            this.btn_Valider.TabIndex = 4;
            this.btn_Valider.Text = "Enregistrer";
            this.btn_Valider.UseVisualStyleBackColor = true;
            // 
            // cbxCourantArtiste
            // 
            this.cbxCourantArtiste.FormattingEnabled = true;
            this.cbxCourantArtiste.Location = new System.Drawing.Point(132, 204);
            this.cbxCourantArtiste.Name = "cbxCourantArtiste";
            this.cbxCourantArtiste.Size = new System.Drawing.Size(121, 21);
            this.cbxCourantArtiste.TabIndex = 5;
            // 
            // lbl_Courant
            // 
            this.lbl_Courant.AutoSize = true;
            this.lbl_Courant.Location = new System.Drawing.Point(12, 212);
            this.lbl_Courant.Name = "lbl_Courant";
            this.lbl_Courant.Size = new System.Drawing.Size(94, 13);
            this.lbl_Courant.TabIndex = 6;
            this.lbl_Courant.Text = "Courant de l\'artiste";
            // 
            // FrmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 452);
            this.Controls.Add(this.lbl_Courant);
            this.Controls.Add(this.cbxCourantArtiste);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.txt_siteArtiste);
            this.Controls.Add(this.txt_nomArtiste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomArtiste);
            this.Name = "FrmAjoutArtiste";
            this.Text = "FrmAjoutArtiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomArtiste;
        private System.Windows.Forms.TextBox txt_siteArtiste;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cbxCourantArtiste;
        private System.Windows.Forms.Label lbl_Courant;
    }
}