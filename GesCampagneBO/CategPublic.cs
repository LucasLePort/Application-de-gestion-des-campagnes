using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class CategPublic
    {
        // déclaration des variables
        private int id;
        private string libelle;

        public CategPublic(int id)
        {
            this.id = id;
        }

        public CategPublic(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
