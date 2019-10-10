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

        public List<Communication> GetCommunications()
        {
            string nomComm;
            string rueComm;
            string telephoneComm;
            string mailComm;
            string siteComm;
            Communication uneComm;
            Ville uneVille;
           string strSQL = "";

            SqlConnection cnx = Connexion.GetObjConnexion();

            //création de la collection lesClients qui va contenir les caractéristiques de tous les clients
            List<Communication> lesComms = new List<Communication>();
            List<Ville> lesVilles = new List<Ville>();

            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

           strSQL="select "
        }
    }
}
