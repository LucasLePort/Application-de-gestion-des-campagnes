using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class CategPublicDAO
    {
        // instanciation de l'instance
        private static CategPublicDAO uneInstance;

        // création de l'instance si elle n'existe pas
        public static CategPublicDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CategPublicDAO();
            }
            return uneInstance;
        }

        // constructeur privé 
        private CategPublicDAO()
        {

        }

        // permet de récupérer 
        public List<CategPublic> GetCategsPublic()
        {
            int idLu;
            string libelleLu;

            CategPublic uneCategPublic;

            string strSQL = "";

            SqlConnection cnx = Connexion.GetObjConnexion();

            //création des différentes collections
            List<CategPublic> lesCategsPublic = new List<CategPublic>();


            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

            strSQL = "select id, libelle from CategPublic";
            maCommande.CommandText = strSQL;

            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {
                if (monLecteur["id"] == DBNull.Value)
                {
                    idLu = default(int);
                }
                else
                {
                    idLu = (int)monLecteur["id"];
                }
                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libelleLu = default(string);
                }
                else
                {
                    libelleLu = monLecteur["libelle"].ToString();
                }

                uneCategPublic = new CategPublic(idLu, libelleLu);

                lesCategsPublic.Add(uneCategPublic);
            }
            monLecteur.Close();
            return lesCategsPublic;
        }
    }
}
