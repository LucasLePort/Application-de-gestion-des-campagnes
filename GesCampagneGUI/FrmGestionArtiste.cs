﻿using System;
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
    public partial class FrmGestionArtiste : Form
    {
        public FrmGestionArtiste()
        {
            InitializeComponent();
        }

        private void btnConsultArtiste_Click(object sender, EventArgs e)
        {
            FrmConsultArtistes maConsultArtiste;
            maConsultArtiste= new FrmConsultArtistes();
            maConsultArtiste.ShowDialog();
        }

        private void btnAjoutArtiste_Click(object sender, EventArgs e)
        {
            FrmAjoutArtiste monAjoutArtiste;
            monAjoutArtiste = new FrmAjoutArtiste();
            monAjoutArtiste.ShowDialog();
        }
    }
} 
