using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    static public class Connexion
    {
        static private SqlConnection objConnex;

        // le constructeur statique crée un objet instance de la classe SqlConnection
        static Connexion()
        {
            objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GesCampagneGSB"].ConnectionString;
        }
        // la méthode GetObjConnexion fournit l'objet instance de
        // la classe SqlConnection dans un état "Connexion ouverte"

        public static SqlConnection GetObjConnexion()
        {
            //on ouvre la connexion si elle est fermée
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            return objConnex;
        }
        // la méthode CloseConnexion met l'objet instance de
        // la classe SqlConnection dans un état "connexion fermée"
        public static void CloseConnection()
        {
            // si la connexion est ouverte la ferme
            if (objConnex != null && objConnex.State != System.Data.ConnectionState.Closed)
            {
                objConnex.Close();
            }
        }
    }
}
