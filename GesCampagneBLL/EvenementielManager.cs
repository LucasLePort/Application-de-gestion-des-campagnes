﻿using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class EvenementielManager
    {
        private static EvenementielManager uneInstance;

        //cette méthode crée un objet de la classe CommunicatonManager s'il n'existe pas déja un
        //puis retourne la référence à cet objet
        public static EvenementielManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementielManager();
            }
            return uneInstance;
        }
        //le constructeur par défaut est privé: il ne sera pas possible de créer un
        //objet à l'extérieur de la classe avec l'instruction new...
        private EvenementielManager()
        {

        }

        //appel de la couche DAL pour récupérer une collection de communications
        public List<Evenementiel> GetCommunications()
        {
            //ici on peut appliquer des règles métier
            return EvenementielDAO.GetInstance().GetEvenementiels();
        }

        //appel de la couche DAL ppur créer une nouvelle agence de Communication 
        public int CreerEvenementiel(string sonNom, string saRue, string sonTelephone, string sonMail, string sonSite, int saVille, out string erreur)
        {
            erreur = "";
            Evenementiel leEvent;
            Ville laVille;
            int ajoutEvent= 0;


            if (sonNom == "")
            {
                erreur += "\nVeuillez saisir le nom du l'agence";
            }
            if (saRue == "")
            {
                erreur += "\nVeuillez saisir la rue de l'agence";
            }
            if (sonTelephone == "")
            {
                erreur += "\nVeuillez saisir le numéro de téléphone de l'agence";
            }
            if (sonMail == "")
            {
                erreur += "\nVeuillez saisir l'adresse mail de l'agence";
            }
            if (sonSite == "")
            {
                erreur += "\nVeuillez saisir le nom du site web de l'agence";
            }
            if (saVille == 0)
            {
                erreur += "\nVeuillez sélectionner la ville de l'agence";
            }
            if (erreur == "")
            {
                laVille = new Ville(saVille);
                leEvent = new Evenementiel(sonNom, saRue, sonTelephone, sonMail, sonSite, laVille);

                try
                {
                    ajoutEvent = EvenementielDAO.GetInstance().AjoutEvent(leEvent);
                }
                catch (Exception err)
                {
                    erreur = "Erreur lors de la création de l'agence de communication" + err.Message;
                }
            }
            return ajoutEvent;
        }
    }
}
