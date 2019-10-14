using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class VilleManager
    {
        private static VilleManager uneInstance;

        //cette méthode crée un objet de la classe ClientManager s'il n'existe pas déja un
        //puis retourne la référence à cet objet
        public static VilleManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleManager();
            }
            return uneInstance;
        }
        //le constructeur par défaut est privé: il ne sera pas possible de créer un
        //objet à l'extérieur de la classe avec l'instruction new...
        private VilleManager()
        {

        }

        //appel de la couche DAL pour récupérer une collection de clients
        public List<Ville> GetVilles()
        {
            //ici on peut appliquer des règles métier
            return VilleDAO.GetInstance().GetVilles();
        }
    }
}
