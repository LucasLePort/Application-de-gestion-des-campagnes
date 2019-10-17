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
    public partial class FrmAjoutArtiste : Form
    {
        public FrmAjoutArtiste()
        {
            InitializeComponent();
            List<Courant> lesCourants;
            lesCourants = CourantManager.GetInstance().GetCourant();
            cbxCourantArtiste.DisplayMember = "libelle";
            cbxCourantArtiste.ValueMember = "id";
            cbxCourantArtiste.DataSource = lesCourants;
            cbxCourantArtiste.SelectedIndex = -1;
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            
            string message = "";
            string erreur = "";
            int nbAjout = 0;


            nbAjout = ArtisteManager.GetInstance().CreerArtiste(txt_nomArtiste.Text, txt_siteArtiste.Text, (int)cbxCourantArtiste.SelectedValue, out erreur);
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


            txt_nomArtiste.Text = "";
            txt_siteArtiste.Text = "";
            cbxCourantArtiste.Text ="";

        }
    }
}
