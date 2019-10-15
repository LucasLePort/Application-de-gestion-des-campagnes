namespace GesCampagneGUI
{
    partial class FrmConsultEvenement
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
            this.dtgConsultEvenement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultEvenement
            // 
            this.dtgConsultEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultEvenement.Location = new System.Drawing.Point(70, 29);
            this.dtgConsultEvenement.Name = "dtgConsultEvenement";
            this.dtgConsultEvenement.Size = new System.Drawing.Size(648, 345);
            this.dtgConsultEvenement.TabIndex = 0;
            // 
            // FrmConsultEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultEvenement);
            this.Name = "FrmConsultEvenement";
            this.Text = "FrmConsultEvenement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEvenement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultEvenement;
    }
}