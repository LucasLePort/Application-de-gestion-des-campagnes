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
    public partial class FrmAjoutEvenement : Form
    {
        public FrmAjoutEvenement()
        {
            InitializeComponent();
            List<Ville> lesVilles;
            lesVilles = VilleManager.GetInstance().GetVilles();
            List<Evenementiel> lesEvenementiels;
            lesEvenementiels = EvenementielManager.GetInstance().GetEvenementiels();
            cbxVille.DataSource = lesVilles;
            cbxVille.ValueMember = "id";
            cbxVille.DisplayMember = "libelle";
            cbxEvenementiel.DataSource = lesEvenementiels;
            cbxEvenementiel.ValueMember = "id";
            cbxEvenementiel.DisplayMember = "nom";

        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            string message = "";
            string erreur ="";
            int nbAjout=0;
            DateTime dateDebut = dtpDateDebut.Value;
            DateTime dateFin = dtpDateFin.Value;


            nbAjout = EvenementManager.GetInstance().CreerEvenement(txtTheme.Text, txtLibelle.Text, dateDebut, dateFin ,(int)cbxVille.SelectedValue, (int)cbxEvenementiel.SelectedValue, out erreur);
            if (nbAjout == 0)
            {
                message = "Aucun événement n'a été ajoutée";
            }
            else
            {
                message = "L'événement a bien été créé";
            }
            if (erreur != "")
            {
                message = erreur;
            }
            MessageBox.Show(message);
            

            txtTheme.Text = "";
            txtLibelle.Text = "";
            dtpDateDebut.Text = "";
            dtpDateFin.Text = "";
            cbxVille.Text = "";
            cbxEvenementiel.Text = "";
        }
    }
}
