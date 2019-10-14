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
    }
}
