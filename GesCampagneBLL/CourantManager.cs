using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class CourantManager
    {
        private static CourantManager uneInstance;

        public static CourantManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CourantManager();
            }
            return uneInstance;
        }
        public List<Courant> GetCourant()
        {
            // ici, on peut appliquer des règles métier
            return CourantDAO.GetInstance().GetCourant();
        }

    }
}
