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
    public partial class FrmGestionAgence : Form
    {
        public FrmGestionAgence()
        {
            InitializeComponent();
        }

        private void btn_AjoutAgence_Click(object sender, EventArgs e)
        {
            FrmAjoutAgence uneAgence;
            uneAgence = new FrmAjoutAgence();
            uneAgence.ShowDialog();
        }

        private void btn_ConsultAgence_Click(object sender, EventArgs e)
        {
            FrmConsultAgence uneAgence;
            uneAgence = new FrmConsultAgence();
            uneAgence.Show();
        }
    }
}
