namespace GesCampagneGUI
{
    partial class FrmGestionArtiste
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
            this.btn_ModifArtiste = new System.Windows.Forms.Button();
            this.btnConsultArtiste = new System.Windows.Forms.Button();
            this.btnAjoutArtiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ModifArtiste
            // 
            this.btn_ModifArtiste.Location = new System.Drawing.Point(332, 168);
            this.btn_ModifArtiste.Name = "btn_ModifArtiste";
            this.btn_ModifArtiste.Size = new System.Drawing.Size(134, 115);
            this.btn_ModifArtiste.TabIndex = 5;
            this.btn_ModifArtiste.Text = "Modification des artistes";
            this.btn_ModifArtiste.UseVisualStyleBackColor = true;
            // 
            // btnConsultArtiste
            // 
            this.btnConsultArtiste.Location = new System.Drawing.Point(505, 168);
            this.btnConsultArtiste.Name = "btnConsultArtiste";
            this.btnConsultArtiste.Size = new System.Drawing.Size(127, 115);
            this.btnConsultArtiste.TabIndex = 4;
            this.btnConsultArtiste.Text = "Consultation des artistes";
            this.btnConsultArtiste.UseVisualStyleBackColor = true;
            this.btnConsultArtiste.Click += new System.EventHandler(this.btnConsultArtiste_Click);
            // 
            // btnAjoutArtiste
            // 
            this.btnAjoutArtiste.Location = new System.Drawing.Point(169, 168);
            this.btnAjoutArtiste.Name = "btnAjoutArtiste";
            this.btnAjoutArtiste.Size = new System.Drawing.Size(127, 115);
            this.btnAjoutArtiste.TabIndex = 3;
            this.btnAjoutArtiste.Text = "Ajout d\'un artiste";
            this.btnAjoutArtiste.UseVisualStyleBackColor = true;
            this.btnAjoutArtiste.Click += new System.EventHandler(this.btnAjoutArtiste_Click);
            // 
            // FrmGestionArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ModifArtiste);
            this.Controls.Add(this.btnConsultArtiste);
            this.Controls.Add(this.btnAjoutArtiste);
            this.Name = "FrmGestionArtiste";
            this.Text = "Menu artiste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ModifArtiste;
        private System.Windows.Forms.Button btnConsultArtiste;
        private System.Windows.Forms.Button btnAjoutArtiste;
    }
}