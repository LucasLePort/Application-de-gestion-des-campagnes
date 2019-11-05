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
        public FrmConsultAgence()
        {
            InitializeComponent();
            List<Communication> lesComms;
            List<Evenementiel> lesEvents;
            List<Agence> lesAgences;

            lesComms = CommunicationManager.GetInstance().GetCommunications();
            lesEvents = EvenementielManager.GetInstance().GetEvenementiels();

            dtgAgence.DataSource = null;
            dtgAgence.DataSource = lesEvents ;
            dtgAgence.Visible = true;
            dtgAgence.Columns[0].Visible = false;
            dtgAgence.Columns[6].Visible = false;
            dtgAgence.Columns[7].HeaderText = "Ville";

        }
    }
}
