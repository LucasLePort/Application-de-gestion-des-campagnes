using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class EvenementManager
    {
        private static EvenementManager uneInstance;

        //cette méthode crée un objet de la classe ClientManager s'il n'existe pas déjà un
        //puis retourne la référence à cet objet
        public static EvenementManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementManager();
            }
            return uneInstance;
        }
        //le constructeur par défaut est privé: il ne sera donc pas possible de créer un
        //objet à l'extérieur de la classe avec l'instructeur new...
        private EvenementManager()
        {

        }
        //appel de la couche DAL pour récupérer une collection de clients
        public List<Evenement> GetEvenements()
        {
            //ici, on peut appliquer des règles métier
            return EvenementDAO.GetInstance().GetEvenements();
        }
        //appel de la couche DAL pour créer un nouveau client
        public int CreerEvenement(string sonTheme, string sonLibelle, DateTime saDateDebut,DateTime saDateFin, int saVille, int sonEvenementiel, out string msgErreur)
        {
            msgErreur = "";
            Evenement leEvenement;
            Evenementiel leEvenementiel;
            Ville laVille;
            DateTime dateDuJour = DateTime.Today;
            int ajoutEvenement = 0;
            if (sonTheme == "")
            {
                msgErreur += "\nVeuillez saisir le thème de l'événement";
            }
            if (sonLibelle == "")
            {
                msgErreur += "\nVeuillez saisir le libellé de l'événement";
            }
            if (saDateDebut == null)
            {
                msgErreur += "\nVeuillez saisir la date du début de l'événement";
            }
            if (saDateFin == null)
            {
                msgErreur += "\nVeuillez saisir la date de fin de l'événement";
            }
            if (saVille == 0)
            {
                msgErreur += "\nVeuillez saisir la bonne ville de l'événement";
            }
            if (sonEvenementiel == 0)
            {
                msgErreur += "\nVeuillez saisir l'événementiel correspondant à l'événement";
            }
            if(saDateDebut < dateDuJour)
            {
               msgErreur += "\nLa date de début de l'événement est inférieur à la date du jour";
            }
            if(saDateDebut > saDateFin)
            {
                msgErreur += "\nLa date de début de l'événement est supérieur à la date de fin de l'événement";
            }
            if (msgErreur == "")
            {
                laVille = new Ville(saVille);
                leEvenementiel = new Evenementiel(sonEvenementiel);
                leEvenement = new Evenement(sonTheme, sonLibelle, saDateDebut, saDateFin, laVille, leEvenementiel);
                try
                {
                    ajoutEvenement = EvenementDAO.GetInstance().AjoutEvenement(leEvenement);
                }
                catch (Exception err)
                {
                    msgErreur = "Erreur lors de la création du client" + err.Message;
                }
            }
            return ajoutEvenement;
        }
    }
}
