namespace GesCampagneGUI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesCaractDesCampagnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesÉvénementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesVIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesArtistesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem,
            this.consultationDesCaractDesCampagnesToolStripMenuItem,
            this.gererLesÉvénementsToolStripMenuItem,
            this.gererLesVIPsToolStripMenuItem,
            this.gererLesArtistesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mnuGestion";
            // 
            // consultationDesCaractéristiqueDuneAgenceToolStripMenuItem
            // 
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem.Name = "consultationDesCaractéristiqueDuneAgenceToolStripMenuItem";
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem.Text = "Gerer les agences";
            this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem.Click += new System.EventHandler(this.consultationDesCaractéristiqueDuneAgenceToolStripMenuItem_Click);
            // 
            // consultationDesCaractDesCampagnesToolStripMenuItem
            // 
            this.consultationDesCaractDesCampagnesToolStripMenuItem.Name = "consultationDesCaractDesCampagnesToolStripMenuItem";
            this.consultationDesCaractDesCampagnesToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.consultationDesCaractDesCampagnesToolStripMenuItem.Text = "Gerer les campagnes";
            this.consultationDesCaractDesCampagnesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesCaractDesCampagnesToolStripMenuItem_Click);
            // 
            // gererLesÉvénementsToolStripMenuItem
            // 
            this.gererLesÉvénementsToolStripMenuItem.Name = "gererLesÉvénementsToolStripMenuItem";
            this.gererLesÉvénementsToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.gererLesÉvénementsToolStripMenuItem.Text = "Gerer les événements";
            this.gererLesÉvénementsToolStripMenuItem.Click += new System.EventHandler(this.gererLesÉvénementsToolStripMenuItem_Click);
            // 
            // gererLesVIPsToolStripMenuItem
            // 
            this.gererLesVIPsToolStripMenuItem.Name = "gererLesVIPsToolStripMenuItem";
            this.gererLesVIPsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.gererLesVIPsToolStripMenuItem.Text = "Gerer les VIPs";
            this.gererLesVIPsToolStripMenuItem.Click += new System.EventHandler(this.gererLesVIPsToolStripMenuItem_Click);
            // 
            // gererLesArtistesToolStripMenuItem
            // 
            this.gererLesArtistesToolStripMenuItem.Name = "gererLesArtistesToolStripMenuItem";
            this.gererLesArtistesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gererLesArtistesToolStripMenuItem.Text = "Gerer les artistes";
            this.gererLesArtistesToolStripMenuItem.Click += new System.EventHandler(this.gererLesArtistesToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationDesCaractéristiqueDuneAgenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesCaractDesCampagnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesÉvénementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesVIPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesArtistesToolStripMenuItem;
    }
}

