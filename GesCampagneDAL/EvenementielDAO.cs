using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class EvenementielDAO
    {
        private static EvenementielDAO uneInstance;

        public static EvenementielDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementielDAO();
            }
            return uneInstance;
        }

        private EvenementielDAO()
        {

        }

        public List<Evenementiel> GetEvenementiels()
        {

        }
    }
}
