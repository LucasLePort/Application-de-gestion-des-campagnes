using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Communication
    {
        private int id;
        private string nom;
        private string rue;
        private string telephone;
        private string mail;
        private string site;
        private Ville laVille;

        public Communication(int id)
        {
            this.id = id;
        }

        public Communication(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Communication(string nom, string rue, string telephone, string mail, string site, Ville laVille)
        {
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.mail = mail;
            this.site = site;
            this.laVille = laVille;
        }

        public Communication(int id, string nom, string rue, string telephone, string mail, string site, Ville laVille)
        {
            this.Id = id;
            this.Nom = nom;
            this.Rue = rue;
            this.Telephone = telephone;
            this.Mail = mail;
            this.Site = site;
            this.LaVille = laVille;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Site { get => site; set => site = value; }
        public Ville LaVille { get => laVille; set => laVille = value; }
        public  string LibelleVille { get => LaVille.Libelle;}

    }
}
