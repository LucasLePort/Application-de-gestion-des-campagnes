using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Ville
    {
        private int id;
        private string codeInsee;
        private string libelle;
        private string codePostal;

        public string CodeInsee { get => codeInsee; set => codeInsee = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }

        public Ville(string codeInsee, string libelle, string codePostal)
        {
            this.codeInsee = codeInsee;
            this.libelle = libelle;
            this.codePostal = codePostal;
        }

        public Ville(int id)
        {
            this.id = id;
        }

        public Ville(int id, string codeInsee, string libelle, string codePostal)
        {
            this.id = id;
            this.codeInsee = codeInsee;
            this.libelle = libelle;
            this.codePostal = codePostal;
        }
    }
}
