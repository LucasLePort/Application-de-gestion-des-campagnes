using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneBLL
{
    public class ArtisteManager
    {
        private static ArtisteManager uneInstance;
        public static ArtisteManager GetInstance()
        {

            if (uneInstance == null)
            {
                uneInstance = new ArtisteManager();
            }
            return uneInstance;
        }

        public List<Artiste> GetArtistes()
        {
            return 
        }
    }
}
