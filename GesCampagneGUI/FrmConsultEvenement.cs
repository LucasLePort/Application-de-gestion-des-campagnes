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
            List<Evenement> lesEvenements;
            List<Ville> lesVilles;
            lesEvenements = EvenementManager.GetInstance().GetEvenements();
            lesVilles = VilleManager.GetInstance().GetVilles();
            this.lesEvenements = lesEvenements;
            dtgConsultEvenement.DataSource = lesEvenements;
            dtgConsultEvenement.Columns["id"].Visible = false;
            dtgConsultEvenement.Columns["laVille"].Visible = false;
            dtgConsultEvenement.Columns["libelleVille"].HeaderText = "Nom de de la ville";
            dtgConsultEvenement.Columns["leEvenementiel"].Visible = false;
            dtgConsultEvenement.Columns["libelleEvenementiel"].HeaderText = "Nom de de l'événementiel";
            cbxChoixVille.DataSource = lesVilles;
            cbxChoixVille.ValueMember = "id";
            cbxChoixVille.DisplayMember = "libelle";
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDebut.Value;
            DateTime dateFin = dtpFin.Value;
            string choixVille = cbxChoixVille.Text;
            List<Evenement> lesEvenementsPeriodes = new List<Evenement>();

            foreach (Evenement unEvent in lesEvenements)
            {
                if(unEvent.DateDebut > dateDebut && unEvent.DateFin < dateFin && dateDebut < dateFin && unEvent.libelleVille == choixVille)
                {
                    lesEvenementsPeriodes.Add(unEvent);

                }
            }
            dtgConsultEvenement.DataSource = lesEvenementsPeriodes;
            
        }
    }
}
