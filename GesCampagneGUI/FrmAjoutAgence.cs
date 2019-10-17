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
    public partial class FrmAjoutAgence : Form
    {
        public FrmAjoutAgence()
        {
            InitializeComponent();
            List<Ville> lesVilles;
            lesVilles = VilleManager.GetInstance().GetVilles();
            cbxVille.DataSource = lesVilles;
            cbxVille.ValueMember = "id";
            cbxVille.DisplayMember = "libelle";
        }

        private void btnAjouterAgence_Click(object sender, EventArgs e)
        {
            string message = "";
            string erreur;
            int nbAjout;
            if (rbtComm.Checked == true)
            {
                nbAjout = CommunicationManager.GetInstance().CreerCommunication(txtNom.Text, txtRue.Text, txtNum.Text, txtMail.Text, txtSite.Text, (int)cbxVille.SelectedValue, out erreur);
                if (nbAjout == 0)
                {
                    message = "Aucune agence de communication n'a été ajoutée";
                }
                else
                {
                    message = "L'agence de communication a bien été créée";
                }
                if (erreur != "")
                {
                    message = erreur;
                }
            }
            else
            {
                if (rbtEvent.Checked == true)
                {
                    nbAjout = EvenementielManager.GetInstance().CreerEvenementiel(txtNom.Text, txtRue.Text, txtNum.Text, txtMail.Text, txtSite.Text, (int)cbxVille.SelectedValue, out erreur);
                    if (nbAjout == 0)
                    {
                        message = "Aucune agence d'évenementiel n'a été ajoutée";
                    }
                    else
                    {
                        message = "L'agence d'évenementiel a bien été créée";
                    }
                    if (erreur != "")
                    {
                        message = erreur;
                    }
                }

                MessageBox.Show(message);
                txtNom.Text = "";
                txtRue.Text = "";
                txtNum.Text = "";
                txtMail.Text = "";
                txtSite.Text = "";

            }
        }
    }
}
