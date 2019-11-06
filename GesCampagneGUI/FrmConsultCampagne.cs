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

            pnlDataGrid.Visible = false;
            pnlRechercheNom.Visible = false;
            pnlRecherchePeriode.Visible = false;

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
            // permet de faire un tri sur les campagnes en fonction de CHAQUE lettre du nom
            var result = lesCampagnes.Where(x => x.Intitule.ToString().Contains(txtRechercheNom.Text)).ToList();
            dtgConsultCampagnes.DataSource = result;
        }

        private void rbtRechercheNom_CheckedChanged(object sender, EventArgs e)
        {
            // on réinitialise notre datagrid
            dtgConsultCampagnes.DataSource = lesCampagnes;
            // quand on clique sur le radio boutton nom, on rend visible les panels permettant la recherche par nom ainsi que le panel qui contient notre datagrid
            pnlRecherchePeriode.Visible = false;
            pnlRechercheNom.Visible = true;
            pnlDataGrid.Visible = true;
        }

        private void rbtRecherchePeriode_CheckedChanged(object sender, EventArgs e)
        {
            // quand on clique sur le radio boutton période, on rend visible le panel permettant la recherche par période
            pnlRechercheNom.Visible = false;
            pnlDataGrid.Visible = false;
            pnlRecherchePeriode.Visible = true;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            // on fait un parcours de liste pour avoir une liste de campagnes qui sont dans la période saisie par l'utilisateur
            List<Campagne> lesCampagnesPeriodes = new List<Campagne>();

            foreach(Campagne uneCampagne in lesCampagnes)
            {
                if (uneCampagne.DateDebut >= dtpDateDebutPeriode.Value && uneCampagne.DateFin <= dtpDateFinPeriode.Value && dtpDateDebutPeriode.Value<dtpDateFinPeriode.Value)
                {
                    lesCampagnesPeriodes.Add(uneCampagne);
                }
            }
            dtgConsultCampagnes.DataSource = lesCampagnesPeriodes;
            pnlDataGrid.Visible = true;
        }
    }
}
