using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBO
{
    public class Campagne
    {
        // déclaration des variables
        private int id;
        private string intitule;
        private string objectif;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Communication laCommunication;
        private Evenementiel lEvenementiel;
        private CategPublic laCategPublic;

        // constructeur sans id
        public Campagne(string intitule, string objectif, DateTime dateDebut, DateTime dateFin, Communication laCommunication, Evenementiel lEvenementiel, CategPublic laCategPublic)
        {
            this.intitule = intitule;
            this.objectif = objectif;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.laCommunication = laCommunication;
            this.lEvenementiel = lEvenementiel;
            this.laCategPublic = laCategPublic;
        }

        // constructeur complet
        public Campagne(int id, string intitule, string objectif, DateTime dateDebut, DateTime dateFin, Communication laCommunication, Evenementiel lEvenementiel, CategPublic laCategPublic)
        {
            this.id = id;
            this.intitule = intitule;
            this.objectif = objectif;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.laCommunication = laCommunication;
            this.lEvenementiel = lEvenementiel;
            this.laCategPublic = laCategPublic;
        }

        // propriétés
        public int Id { get => id; set => id = value; }
        public string Intitule { get => intitule; set => intitule = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public Communication LaCommunication { get => laCommunication; set => laCommunication = value; }
        public Evenementiel LEvenementiel { get => lEvenementiel; set => lEvenementiel = value; }
        public CategPublic LaCategPublic { get => laCategPublic; set => laCategPublic = value; }
    }
}
