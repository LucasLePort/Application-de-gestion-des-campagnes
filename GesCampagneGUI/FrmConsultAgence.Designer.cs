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
            this.rbtEvent = new System.Windows.Forms.RadioButton();
            this.rbtComm = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAgence
            // 
            this.dtgAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgence.Location = new System.Drawing.Point(76, 203);
            this.dtgAgence.Name = "dtgAgence";
            this.dtgAgence.Size = new System.Drawing.Size(665, 211);
            this.dtgAgence.TabIndex = 0;
            // 
            // rbtEvent
            // 
            this.rbtEvent.AutoSize = true;
            this.rbtEvent.Location = new System.Drawing.Point(149, 56);
            this.rbtEvent.Name = "rbtEvent";
            this.rbtEvent.Size = new System.Drawing.Size(174, 17);
            this.rbtEvent.TabIndex = 1;
            this.rbtEvent.TabStop = true;
            this.rbtEvent.Text = "Voir les agences évenementiels";
            this.rbtEvent.UseVisualStyleBackColor = true;
            this.rbtEvent.CheckedChanged += new System.EventHandler(this.rbtEvent_CheckedChanged);
            // 
            // rbtComm
            // 
            this.rbtComm.AutoSize = true;
            this.rbtComm.Location = new System.Drawing.Point(460, 56);
            this.rbtComm.Name = "rbtComm";
            this.rbtComm.Size = new System.Drawing.Size(197, 17);
            this.rbtComm.TabIndex = 2;
            this.rbtComm.TabStop = true;
            this.rbtComm.Text = "Voir les agences de communications";
            this.rbtComm.UseVisualStyleBackColor = true;
            this.rbtComm.CheckedChanged += new System.EventHandler(this.rbtComm_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(316, 145);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Réinitialiser les critères";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmConsultAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbtComm);
            this.Controls.Add(this.rbtEvent);
            this.Controls.Add(this.dtgAgence);
            this.Name = "FrmConsultAgence";
            this.Text = "Consultation des agences";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAgence;
        private System.Windows.Forms.RadioButton rbtEvent;
        private System.Windows.Forms.RadioButton rbtComm;
        private System.Windows.Forms.Button btnReset;
    }
}