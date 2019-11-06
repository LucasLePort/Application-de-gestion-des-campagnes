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
    public partial class FrmConsultArtistes : Form
    {
        List<Artiste> lesArtistes;
        public FrmConsultArtistes()
        {
            InitializeComponent();
            List<Artiste> lesArtistes;
            
            lesArtistes = ArtisteManager.GetInstance().GetArtistes();
            this.lesArtistes = lesArtistes;
            dtgArtiste.DataSource = lesArtistes;
            dtgArtiste.Columns["id"].Visible = false;
            dtgArtiste.Columns[3].Visible = false;
            

        }

        private void txtCritereNom_TextChanged(object sender, EventArgs e)
        {
            var result = lesArtistes.Where(x => x.Nom.ToString().Contains(txtCritereNom.Text)).ToList();
            dtgArtiste.DataSource = result;
        }
    }
}
