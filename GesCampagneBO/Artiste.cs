using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Artiste
    {
        // déclaration des variables
        private int id;
        private string nom;

        // constructeur
        public Artiste(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
        // méthode
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
