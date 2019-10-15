namespace GesCampagneGUI
{
    partial class FrmGestionVip
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
            this.btn_ConsultVip = new System.Windows.Forms.Button();
            this.btn_ModifVip = new System.Windows.Forms.Button();
            this.btn_AjoutVip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConsultVip
            // 
            this.btn_ConsultVip.Location = new System.Drawing.Point(503, 168);
            this.btn_ConsultVip.Name = "btn_ConsultVip";
            this.btn_ConsultVip.Size = new System.Drawing.Size(131, 115);
            this.btn_ConsultVip.TabIndex = 5;
            this.btn_ConsultVip.Text = "Consultation des VIPs";
            this.btn_ConsultVip.UseVisualStyleBackColor = true;
            // 
            // btn_ModifVip
            // 
            this.btn_ModifVip.Location = new System.Drawing.Point(338, 168);
            this.btn_ModifVip.Name = "btn_ModifVip";
            this.btn_ModifVip.Size = new System.Drawing.Size(131, 115);
            this.btn_ModifVip.TabIndex = 4;
            this.btn_ModifVip.Text = "Modifier un VIP";
            this.btn_ModifVip.UseVisualStyleBackColor = true;
            // 
            // btn_AjoutVip
            // 
            this.btn_AjoutVip.Location = new System.Drawing.Point(166, 168);
            this.btn_AjoutVip.Name = "btn_AjoutVip";
            this.btn_AjoutVip.Size = new System.Drawing.Size(131, 115);
            this.btn_AjoutVip.TabIndex = 3;
            this.btn_AjoutVip.Text = "Ajouter des VIPs";
            this.btn_AjoutVip.UseVisualStyleBackColor = true;
            // 
            // FrmGestionVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ConsultVip);
            this.Controls.Add(this.btn_ModifVip);
            this.Controls.Add(this.btn_AjoutVip);
            this.Name = "FrmGestionVip";
            this.Text = "Menu VIP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultVip;
        private System.Windows.Forms.Button btn_ModifVip;
        private System.Windows.Forms.Button btn_AjoutVip;
    }
}