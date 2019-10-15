namespace GesCampagneGUI
{
    partial class FrmGestionAgence
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
            this.btn_ModifAgence = new System.Windows.Forms.Button();
            this.btn_ConsultAgence = new System.Windows.Forms.Button();
            this.btn_AjoutAgence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ModifAgence
            // 
            this.btn_ModifAgence.Location = new System.Drawing.Point(485, 166);
            this.btn_ModifAgence.Name = "btn_ModifAgence";
            this.btn_ModifAgence.Size = new System.Drawing.Size(132, 118);
            this.btn_ModifAgence.TabIndex = 5;
            this.btn_ModifAgence.Text = "Modifications des agences";
            this.btn_ModifAgence.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultAgence
            // 
            this.btn_ConsultAgence.Location = new System.Drawing.Point(337, 166);
            this.btn_ConsultAgence.Name = "btn_ConsultAgence";
            this.btn_ConsultAgence.Size = new System.Drawing.Size(116, 118);
            this.btn_ConsultAgence.TabIndex = 4;
            this.btn_ConsultAgence.Text = "Consulter les agences";
            this.btn_ConsultAgence.UseVisualStyleBackColor = true;
            // 
            // btn_AjoutAgence
            // 
            this.btn_AjoutAgence.Location = new System.Drawing.Point(184, 166);
            this.btn_AjoutAgence.Name = "btn_AjoutAgence";
            this.btn_AjoutAgence.Size = new System.Drawing.Size(121, 118);
            this.btn_AjoutAgence.TabIndex = 3;
            this.btn_AjoutAgence.Text = "Ajouter une agence";
            this.btn_AjoutAgence.UseVisualStyleBackColor = true;
            this.btn_AjoutAgence.Click += new System.EventHandler(this.btn_AjoutAgence_Click);
            // 
            // FrmGestionAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ModifAgence);
            this.Controls.Add(this.btn_ConsultAgence);
            this.Controls.Add(this.btn_AjoutAgence);
            this.Name = "FrmGestionAgence";
            this.Text = "Menu de gestion des agence";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ModifAgence;
        private System.Windows.Forms.Button btn_ConsultAgence;
        private System.Windows.Forms.Button btn_AjoutAgence;
    }
}