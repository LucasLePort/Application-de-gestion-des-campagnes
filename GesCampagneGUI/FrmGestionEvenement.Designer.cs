namespace GesCampagneGUI
{
    partial class FrmGestionEvenement
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
            this.btn_ConsultEvenement = new System.Windows.Forms.Button();
            this.btn_ModifEvenement = new System.Windows.Forms.Button();
            this.btn_AjoutEvenement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConsultEvenement
            // 
            this.btn_ConsultEvenement.Location = new System.Drawing.Point(499, 164);
            this.btn_ConsultEvenement.Name = "btn_ConsultEvenement";
            this.btn_ConsultEvenement.Size = new System.Drawing.Size(139, 122);
            this.btn_ConsultEvenement.TabIndex = 5;
            this.btn_ConsultEvenement.Text = "Consulter les événements ";
            this.btn_ConsultEvenement.UseVisualStyleBackColor = true;
            this.btn_ConsultEvenement.Click += new System.EventHandler(this.btn_ConsultEvenement_Click);
            // 
            // btn_ModifEvenement
            // 
            this.btn_ModifEvenement.Location = new System.Drawing.Point(336, 164);
            this.btn_ModifEvenement.Name = "btn_ModifEvenement";
            this.btn_ModifEvenement.Size = new System.Drawing.Size(132, 122);
            this.btn_ModifEvenement.TabIndex = 4;
            this.btn_ModifEvenement.Text = "Modifier un événement";
            this.btn_ModifEvenement.UseVisualStyleBackColor = true;
            // 
            // btn_AjoutEvenement
            // 
            this.btn_AjoutEvenement.Location = new System.Drawing.Point(167, 164);
            this.btn_AjoutEvenement.Name = "btn_AjoutEvenement";
            this.btn_AjoutEvenement.Size = new System.Drawing.Size(132, 122);
            this.btn_AjoutEvenement.TabIndex = 3;
            this.btn_AjoutEvenement.Text = "Ajouter un événement";
            this.btn_AjoutEvenement.UseVisualStyleBackColor = true;
            this.btn_AjoutEvenement.Click += new System.EventHandler(this.btn_AjoutEvenement_Click);
            // 
            // FrmGestionEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ConsultEvenement);
            this.Controls.Add(this.btn_ModifEvenement);
            this.Controls.Add(this.btn_AjoutEvenement);
            this.Name = "FrmGestionEvenement";
            this.Text = "Menu événement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultEvenement;
        private System.Windows.Forms.Button btn_ModifEvenement;
        private System.Windows.Forms.Button btn_AjoutEvenement;
    }
}