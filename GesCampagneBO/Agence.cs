using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Agence
    {
        private int id;
        private string nom;
        private string rue;
        private string telephone;
        private string mail;
        private string site;
        private Ville laVille;
        private string typeAgence;

        public Agence(int id)
        {
            this.id = id;
        }

        public Agence(string nom, string rue, string telephone, string mail, string site, Ville laVille, string typeAgence)
        {
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.mail = mail;
            this.site = site;
            this.laVille = laVille;
            this.typeAgence = typeAgence;
        }

        public Agence(int id, string nom, string rue, string telephone, string mail, string site, Ville laVille, string typeAgence)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.telephone = telephone;
            this.mail = mail;
            this.site = site;
            this.laVille = laVille;
            this.typeAgence = typeAgence;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Site { get => site; set => site = value; }
        public Ville LaVille { get => laVille; set => laVille = value; }
        public string LibelleVille { get => LaVille.Libelle; }
        public string TypeAgence { get => typeAgence; set => typeAgence = value; }

    }
}
