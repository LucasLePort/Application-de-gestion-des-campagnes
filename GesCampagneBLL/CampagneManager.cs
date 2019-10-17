﻿using GesCampagneBO;
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
        public int CreerCampagne(string sonIntitule, string sonObjectif, DateTime dateDebut, DateTime dateFin, Communication laCommunication, Evenement lEvenement, CategPublic laCategPublic, out string msgErreur)
        {
            msgErreur = "";
            int ajoutCampagne = 0;
            Campagne uneCampagne; 
            
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
            if(laCommunication == null)
            {
                msgErreur += "\nVeuillez sélectionner une agence de communication.";
            }
            if(lEvenement == null)
            {
                msgErreur += "\nVeuillez sélectionner une agence d'évenementiel.";
            }
            if(laCategPublic == null)
            {
                msgErreur += "\nVeuillez sélectionner le public.";
            }

            // si il y tous les paramètres de saisi, on créer la campagne et on l'ajoute dans toutes les campagnes
            if (msgErreur == "")
            {
                uneCampagne = new Campagne(sonIntitule, sonObjectif, dateDebut, dateFin, laCommunication, lEvenement, laCategPublic);
                try
                {
                    ajoutCampagne = CampagneDAO.GetInstance().AjoutCampagne(uneCampagne);
                }
                catch (Exception err)
                {
                    msgErreur = "Erreur lors de la création de la campagne" + err.Message;
                }
            }
            return ajoutCampagne;

        }
    }
}