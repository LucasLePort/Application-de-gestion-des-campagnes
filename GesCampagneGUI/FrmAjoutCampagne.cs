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
    public partial class FrmAjoutCampagne : Form
    {
        public FrmAjoutCampagne()
        {
            InitializeComponent();

            // remplissage de la liste d'agences qui font de l'événementiel
            List<Evenementiel> lesAgencesEvenementiel;
            lesAgencesEvenementiel = EvenementielManager.GetInstance().GetEvenementiels();
            cbxEvenementiel.DisplayMember = "nom";
            cbxEvenementiel.ValueMember = "id";
            cbxEvenementiel.DataSource = lesAgencesEvenementiel;
            cbxEvenementiel.SelectedIndex = -1;

            // remplissage de la liste d'agences qui font de la communication
            List<Communication> lesAgencesCommunication;
            lesAgencesCommunication = CommunicationManager.GetInstance().GetCommunications();
            cbxCommunication.DisplayMember = "nom";
            cbxCommunication.ValueMember = "id";
            cbxCommunication.DataSource = lesAgencesCommunication;
            cbxCommunication.SelectedIndex = -1;

            // remplissage de la liste des catégories de public
            List<CategPublic> lesCategsPublic;
            lesCategsPublic = CategPublicManager.GetInstance().GetCategsPublic();
            cbxCategPublic.DisplayMember = "libelle";
            cbxCategPublic.ValueMember = "id";
            cbxCategPublic.DataSource = lesCategsPublic;
            cbxCategPublic.SelectedIndex = -1;
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string message = "";
            string erreur = "";
            int nbAjout = 0;

            nbAjout = CampagneManager.GetInstance().CreerCampagne(txtIntitule.Text, txtObjectif.Text, dtpDebutCampagne.Value, dtpFinCampagne.Value, (int)cbxEvenementiel.SelectedValue, (int)cbxCommunication.SelectedValue, (int)cbxCategPublic.SelectedValue, out erreur);
            if (nbAjout == 0)
            {
                message = "Aucune campagne n'a été ajouté";
            }
            else
            {
                message = "La campagne a bien été créé";
            }
            if (erreur != "")
            {
                message = erreur;
            }
            MessageBox.Show(message);

            // réinitialisation des champs.
            txtIntitule.Text = "";
            txtObjectif.Text = "";
            dtpDebutCampagne.Text = "";
            dtpFinCampagne.Text = "";
            cbxCommunication.Text = "";
            cbxEvenementiel.Text = "";
            cbxCategPublic.Text = "";

        }
    }
}
