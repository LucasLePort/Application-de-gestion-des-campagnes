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
    public partial class FrmConsultCampagne : Form
    {
        List<Campagne> lesCampagnes;
        public FrmConsultCampagne()
        {
            InitializeComponent();

            List<Campagne> lesCampagnes;
            lesCampagnes = CampagneManager.GetInstance().GetCampagnes();
            this.lesCampagnes = lesCampagnes;
            dtgConsultCampagnes.DataSource = lesCampagnes;
            dtgConsultCampagnes.Columns["id"].Visible = false;

            dtgConsultCampagnes.Columns["LEvenementiel"].Visible = false;
            dtgConsultCampagnes.Columns["LaCommunication"].Visible = false;
            dtgConsultCampagnes.Columns["LaCategPublic"].Visible = false;
            dtgConsultCampagnes.Columns["LUtilisateur"].Visible = false;

            dtgConsultCampagnes.Columns["DateDebut"].HeaderText = "Début de la campagne";
            dtgConsultCampagnes.Columns["DateFin"].HeaderText = "Fin de la campagne";
            dtgConsultCampagnes.Columns["LibelleEvenementiel"].HeaderText = "Nom de l'agence d'événementiel";
            dtgConsultCampagnes.Columns["LibelleCategPublic"].HeaderText = "Catégorie de public";
            dtgConsultCampagnes.Columns["LibelleCommunication"].HeaderText = "Nom de l'agence de communication";
        }

        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {
            var result = lesCampagnes.Where(x => x.Intitule.ToString().Contains(txtRechercheNom.Text)).ToList();
            dtgConsultCampagnes.DataSource = result;
        }
    }
}
