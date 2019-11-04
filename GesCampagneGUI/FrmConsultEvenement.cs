using GesCampagneBLL;
using GesCampagneBO;
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
    public partial class FrmConsultEvenement : Form
    {
        List<Evenement> lesEvenements;
        public FrmConsultEvenement()
        {
            InitializeComponent();            
            lesEvenements = EvenementManager.GetInstance().GetEvenements();
            dtgConsultEvenement.DataSource = lesEvenements;
            dtgConsultEvenement.Columns["id"].Visible = false;
            dtgConsultEvenement.Columns["laVille"].Visible = false;
            dtgConsultEvenement.Columns["libelleVille"].HeaderText = "Nom de de la ville";
            dtgConsultEvenement.Columns["leEvenementiel"].Visible = false;
            dtgConsultEvenement.Columns["libelleEvenementiel"].HeaderText = "Nom de de l'événementiel";
        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
            var result = lesEvenements.Where(x => x.(DateTime)DateDebut.Contains(dtpDebut.Text)).ToList();
            dtgConsultEvenement.DataSource = result;
        }
    }
}
