namespace GesCampagneGUI
{
    partial class FrmConsultAgence
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
            this.dtgAgence = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAgence
            // 
            this.dtgAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgence.Location = new System.Drawing.Point(38, 24);
            this.dtgAgence.Name = "dtgAgence";
            this.dtgAgence.Size = new System.Drawing.Size(645, 328);
            this.dtgAgence.TabIndex = 0;
            // 
            // FrmConsultAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgAgence);
            this.Name = "FrmConsultAgence";
            this.Text = "Consultation des agences";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAgence;
    }
}