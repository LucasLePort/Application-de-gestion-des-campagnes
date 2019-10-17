using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCampagneGUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void gererLesArtistesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionArtiste monArtiste;
            monArtiste = new FrmGestionArtiste();
            monArtiste.ShowDialog(); // on affiche le formulaire
        }

        private void consultationDesCaractDesCampagnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCampagne maCampagne;
            maCampagne = new FrmGestionCampagne();
            maCampagne.ShowDialog();
        }

        private void consultationDesCaractéristiqueDuneAgenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionAgence monAgence;
            monAgence = new FrmGestionAgence();
            monAgence.ShowDialog();
        }

        private void gererLesÉvénementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionEvenement maCampagne;
            maCampagne = new FrmGestionEvenement();
            maCampagne.ShowDialog();
        }

        private void gererLesVIPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionVip unVIP;
            unVIP = new FrmGestionVip();
            unVIP.ShowDialog();
        }

        private void gererLesMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
