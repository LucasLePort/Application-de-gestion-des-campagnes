using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Evenement
    {
        private int id;
        private string theme;
        private string libelle;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Ville laVille;
        private Evenementiel leEvenementiel;


        public string Theme { get => theme; set => theme = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public Ville LaVille { get => laVille; set => laVille = value; }
        public Evenementiel LeEvenementiel { get => leEvenementiel; set => leEvenementiel = value; }
        public int Id { get => id; set => id = value; }

        public Evenement(int id, string theme, string libelle, DateTime dateDebut, DateTime dateFin, Ville laVille, Evenementiel leEvenementiel)
        {
            this.id = id;
            this.theme = theme;
            this.libelle = libelle;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.laVille = laVille;
            this.leEvenementiel = leEvenementiel;
        }
    }
}
