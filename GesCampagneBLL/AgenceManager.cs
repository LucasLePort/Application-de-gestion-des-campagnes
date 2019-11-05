using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class AgenceManager
    {
        private static AgenceManager uneInstance;

        //cette méthode crée un objet de la classe CommunicatonManager s'il n'existe pas déja un
        //puis retourne la référence à cet objet
        public static AgenceManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AgenceManager();
            }
            return uneInstance;
        }
        //le constructeur par défaut est privé: il ne sera pas possible de créer un
        //objet à l'extérieur de la classe avec l'instruction new...
        private AgenceManager()
        {

        }

        //appel de la couche DAL pour récupérer une collection de communications
        public List<Agence> GetCommunications()
        {
            //ici on peut appliquer des règles métier
            return AgenceDAO.GetInstance().GetAgences();
        }
    }
}
