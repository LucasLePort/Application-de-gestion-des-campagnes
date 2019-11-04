namespace GesCampagneGUI
{
    partial class FrmGestionCampagne
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
            this.btn_ModifCampagne = new System.Windows.Forms.Button();
            this.btn_ConsultCampagne = new System.Windows.Forms.Button();
            this.btn_AjoutCampagne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ModifCampagne
            // 
            this.btn_ModifCampagne.Location = new System.Drawing.Point(519, 167);
            this.btn_ModifCampagne.Name = "btn_ModifCampagne";
            this.btn_ModifCampagne.Size = new System.Drawing.Size(113, 117);
            this.btn_ModifCampagne.TabIndex = 5;
            this.btn_ModifCampagne.Text = "Modifier une campagne";
            this.btn_ModifCampagne.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultCampagne
            // 
            this.btn_ConsultCampagne.Location = new System.Drawing.Point(349, 167);
            this.btn_ConsultCampagne.Name = "btn_ConsultCampagne";
            this.btn_ConsultCampagne.Size = new System.Drawing.Size(113, 117);
            this.btn_ConsultCampagne.TabIndex = 4;
            this.btn_ConsultCampagne.Text = "Consulter les campagnes";
            this.btn_ConsultCampagne.UseVisualStyleBackColor = true;
            this.btn_ConsultCampagne.Click += new System.EventHandler(this.btn_ConsultCampagne_Click);
            // 
            // btn_AjoutCampagne
            // 
            this.btn_AjoutCampagne.Location = new System.Drawing.Point(169, 167);
            this.btn_AjoutCampagne.Name = "btn_AjoutCampagne";
            this.btn_AjoutCampagne.Size = new System.Drawing.Size(113, 117);
            this.btn_AjoutCampagne.TabIndex = 3;
            this.btn_AjoutCampagne.Text = "Créer une campagne";
            this.btn_AjoutCampagne.UseVisualStyleBackColor = true;
            this.btn_AjoutCampagne.Click += new System.EventHandler(this.btn_AjoutCampagne_Click);
            // 
            // FrmGestionCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ModifCampagne);
            this.Controls.Add(this.btn_ConsultCampagne);
            this.Controls.Add(this.btn_AjoutCampagne);
            this.Name = "FrmGestionCampagne";
            this.Text = "Menu campagne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ModifCampagne;
        private System.Windows.Forms.Button btn_ConsultCampagne;
        private System.Windows.Forms.Button btn_AjoutCampagne;
    }
}