using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class CategPublicManager
    {
        // initialisation de l'instance
        private static CategPublicManager uneInstance;

        // créer l'instance si elle n'existe pas déja
        public static CategPublicManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CategPublicManager();
            }
            return uneInstance;
        }
        // permet de récupérer toutes les categories de public
        public List<CategPublic> GetCategsPublic()
        {

            return CategPublicDAO.GetInstance().GetCategsPublic();

        }
    }
}
