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
    public partial class FrmConsultAgence : Form
    {
        List<Agence> lesAgences;
        public FrmConsultAgence()
        {
            InitializeComponent();
            List<Communication> lesComms;
            List<Evenementiel> lesEvents;
            List<Agence> lesAgences;

            lesComms = CommunicationManager.GetInstance().GetCommunications();
            lesEvents = EvenementielManager.GetInstance().GetEvenementiels();
            lesAgences = AgenceManager.GetInstance().GetAgences();
            this.lesAgences = lesAgences;

            dtgAgence.DataSource = null;
            dtgAgence.DataSource = lesAgences;
            dtgAgence.Visible = true;
            dtgAgence.Columns[0].Visible = false;
            dtgAgence.Columns[6].Visible = false;
            dtgAgence.Columns[8].Visible = false;
            dtgAgence.Columns["LibelleVille"].HeaderText = "Ville";

        }

        private void rbtEvent_CheckedChanged(object sender, EventArgs e)
        {
            List<Agence> lesAgencesEvent = new List<Agence>();
            foreach(Agence uneAgence in lesAgences)
            {
                if(uneAgence.TypeAgence == "E")
                {
                    lesAgencesEvent.Add(uneAgence);
                }
            }
            dtgAgence.DataSource = lesAgencesEvent;
        }

        private void rbtComm_CheckedChanged(object sender, EventArgs e)
        {
            List<Agence> lesAgencesComm = new List<Agence>();
            foreach(Agence uneAgence in lesAgences)
            {
                if (uneAgence.TypeAgence == "C")
                {
                    lesAgencesComm.Add(uneAgence);
                }
            }
            dtgAgence.DataSource = lesAgencesComm;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgAgence.DataSource = lesAgences;
        }
    }
}
