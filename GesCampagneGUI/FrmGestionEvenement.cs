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
    public partial class FrmGestionEvenement : Form
    {
        public FrmGestionEvenement()
        {
            InitializeComponent();
        }

        private void btn_AjoutEvenement_Click(object sender, EventArgs e)
        {
           FrmAjoutEvenement unEvenement;
           unEvenement = new FrmAjoutEvenement();
           unEvenement.Show();
        }

        private void btn_ConsultEvenement_Click(object sender, EventArgs e)
        {
            FrmConsultEvenement unEvenement;
            unEvenement = new FrmConsultEvenement();
            unEvenement.Show();

        }
    }
}
