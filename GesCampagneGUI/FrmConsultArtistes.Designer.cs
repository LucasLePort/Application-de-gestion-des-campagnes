﻿namespace GesCampagneGUI
{
    partial class FrmConsultArtistes
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
            this.dtgArtiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgArtiste
            // 
            this.dtgArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArtiste.Location = new System.Drawing.Point(240, 115);
            this.dtgArtiste.Name = "dtgArtiste";
            this.dtgArtiste.Size = new System.Drawing.Size(240, 150);
            this.dtgArtiste.TabIndex = 0;
            // 
            // FrmConsultArtistes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgArtiste);
            this.Name = "FrmConsultArtistes";
            this.Text = "FrmConsultArtistes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgArtiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgArtiste;
    }
}