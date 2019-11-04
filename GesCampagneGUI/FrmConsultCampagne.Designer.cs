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
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultCampagnes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultCampagnes
            // 
            this.dtgConsultCampagnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultCampagnes.Location = new System.Drawing.Point(59, 33);
            this.dtgConsultCampagnes.Name = "dtgConsultCampagnes";
            this.dtgConsultCampagnes.Size = new System.Drawing.Size(763, 331);
            this.dtgConsultCampagnes.TabIndex = 0;
            // 
            // lblRechercheParNom
            // 
            this.lblRechercheParNom.AutoSize = true;
            this.lblRechercheParNom.Location = new System.Drawing.Point(122, 408);
            this.lblRechercheParNom.Name = "lblRechercheParNom";
            this.lblRechercheParNom.Size = new System.Drawing.Size(249, 13);
            this.lblRechercheParNom.TabIndex = 1;
            this.lblRechercheParNom.Text = "Rechercher une campagne en saisissant son nom :";
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Location = new System.Drawing.Point(377, 405);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(308, 20);
            this.txtRechercheNom.TabIndex = 2;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // FrmConsultCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 524);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.lblRechercheParNom);
            this.Controls.Add(this.dtgConsultCampagnes);
            this.Name = "FrmConsultCampagne";
            this.Text = "Consultation des campagnes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultCampagnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultCampagnes;
        private System.Windows.Forms.Label lblRechercheParNom;
        private System.Windows.Forms.TextBox txtRechercheNom;
    }
}