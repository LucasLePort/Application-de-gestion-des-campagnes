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
    public partial class FrmGestionCampagne : Form
    {
        public FrmGestionCampagne()
        {
            InitializeComponent();
        }

        private void btn_AjoutCampagne_Click(object sender, EventArgs e)
        {
            FrmAjoutCampagne uneCampagne;
            uneCampagne = new FrmAjoutCampagne();
            uneCampagne.ShowDialog();
        }

        private void btn_ConsultCampagne_Click(object sender, EventArgs e)
        {
            FrmConsultCampagne uneConsultationDeCampagnes;
            uneConsultationDeCampagnes = new FrmConsultCampagne();
            uneConsultationDeCampagnes.ShowDialog();
        }
    }
}
