using GesCampagneBO;
using GesCampagneDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public int CreerArtiste(string sonNom, string sonSite, int sonCourant, out string msgErreur)
        {
            msgErreur = "";
            int ajoutArtiste = 0;
            Courant unCourant;
            Artiste unArtiste;
            string pattern = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
            Regex url = new Regex(pattern);
            

            if (sonNom == "")
            {
                msgErreur += "\nVeuillez saisir le nom de l'artiste";
            }
            if (sonCourant == 0)
            {
                msgErreur += "\nVeuillez saisir le courant de l'artiste";
            }
            if(url.IsMatch(sonSite) == false)
            {
                msgErreur += "\nVeuillez saisir un url valide (www.nomSite.com)";
            }
            if (msgErreur == "")
            {

                unCourant = new Courant(sonCourant);
                unArtiste = new Artiste(sonNom, sonSite, unCourant);
                try
                {
                    ajoutArtiste = ArtisteDAO.GetInstance().AjoutArtiste(unArtiste);
                }
                catch (Exception err)
                {
                    msgErreur = "Erreur lors de la création du client" + err.Message;
                }
            }
            return ajoutArtiste;
  
        }
    }
}
