using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class CommunicationDAO
    {
        private static CommunicationDAO uneInstance;

        public static CommunicationDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CommunicationDAO();
            }
            return uneInstance;
        }

        private CommunicationDAO()
        {

        }


    }
}
