using GesCampagneBO;
using GesCampagneDAL;
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
            return ArtisteDAO.GetInstance().GetArtistes();

        }
        public int CreerArtiste(string sonNom, string sonSite, int sonCourant)
        {
            Courant unCourant;
            Artiste unArtiste;
            unCourant= new Courant(sonCourant);
            unArtiste = new Artiste(sonNom, sonSite, unCourant);
            return ArtisteDAO.GetInstance().AjoutArtiste(unArtiste);
        }
    }
}
