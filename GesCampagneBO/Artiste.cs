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
        private string site;
        public Artiste(string nom)
        {
            this.nom = nom;
        }

        // constructeur
        public Artiste(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public Artiste(int id, string nom, string site)
        {
            this.id = id;
            this.nom = nom;
            this.Site = site;
        }

        // méthode
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Site { get => site; set => site = value; }
    }
}
