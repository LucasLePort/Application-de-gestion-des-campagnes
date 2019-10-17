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
        public FrmConsultEvenement()
        {
            InitializeComponent();
            List<Evenement> lesEvenements;
            lesEvenements = EvenementManager.GetInstance().GetEvenements();
            dtgConsultEvenement.DataSource = lesEvenements;
            dtgConsultEvenement.Columns["id"].Visible = false;
        }
    }
}
