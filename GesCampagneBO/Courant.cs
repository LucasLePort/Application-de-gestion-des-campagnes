using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Courant
    {
        private int id;
        private string libelle;

        public Courant(string libelle)
        {
            this.libelle = libelle;
        }

        public Courant(int id)
        {
            this.id = id;
        }

        public Courant(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
