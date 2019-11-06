using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class CampagneManager
    {
        // initialisation de l'instance
        private static CampagneManager uneInstance;

        // créer l'instance si elle n'existe pas déja
        public static CampagneManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneManager();
            }
            return uneInstance;
        }
        // permet de récupérer toutes les campagnes
        public List<Campagne> GetCampagnes()
        {

            return CampagneDAO.GetInstance().GetCampagnes();

        }

        // permet de créer une campagne
        public int CreerCampagne(string sonIntitule, string sonObjectif, DateTime dateDebut, DateTime dateFin, int lEvenementiel, int laCommunication, int laCategPublic, out string msgErreur)
        {
            msgErreur = "";
            int ajoutCampagne = 0;
            Campagne uneCampagne;
            Communication uneCommunication;
            Evenementiel unEvenementiel;
            CategPublic uneCategPublic;
            DateTime dateJour = DateTime.Today;

            
            // vérification que tous les paramètres ont été saisi.
            if (sonIntitule == "")
            {
                msgErreur += "\nVeuillez saisir l'intitule de la campagne.";
            }
            if (sonObjectif == "")
            {
                msgErreur += "\nVeuillez saisir l'objectif de la campagne.";
            }
            if(dateDebut == null)
            {
                msgErreur += "\nVeuillez saisir une date de commencement de la campagne.";
            }
            if(dateFin == null)
            {
                msgErreur += "\nVeuillez saisir une date de fin pour la campagne.";
            }           
            if(lEvenementiel == 0)
            {
                msgErreur += "\nVeuillez sélectionner une agence d'évenementiel.";
            }
            if (laCommunication == 0)
            {
                msgErreur += "\nVeuillez sélectionner une agence de communication.";
            }
            if (laCategPublic == 0)
            {
                msgErreur += "\nVeuillez sélectionner le public.";
            }
            if(dateDebut<dateJour)
            {
                msgErreur += "\nVeuillez sélectionner une date supérieur à la date du jour.";
            }
            if(dateDebut>dateFin)
            {
                msgErreur += "\nLa date de début est supérieur à la date de fin.";
            }

            // si il y tous les paramètres de saisi, on créer la campagne et on l'ajoute dans toutes les campagnes
            if (msgErreur == "")
            {
                uneCommunication = new Communication(laCommunication);
                unEvenementiel = new Evenementiel(lEvenementiel);
                uneCategPublic = new CategPublic(laCategPublic);

                uneCampagne = new Campagne(sonIntitule, sonObjectif, dateDebut, dateFin, unEvenementiel, uneCommunication, uneCategPublic, 2);
                try
                {
                    ajoutCampagne = CampagneDAO.GetInstance().AjoutCampagne(uneCampagne);
                }
                catch (Exception err)
                {
                    msgErreur = "Erreur lors de la création de la campagne" + err.Message;
                }
            }

            // on retourne 1 si on a ajouté une campagne, 0 sinon
            return ajoutCampagne;

        }
    }
}
