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
            string ville;
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

            strSQL = "select nom, rue, telephone, mail, site, libelle as 'ville' FROM Communication join Ville on id_ville=Ville.id";
            maCommande.CommandText = strSQL;

            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {
                if (monLecteur["Nom"] == DBNull.Value)
                {
                    nomComm = default(string);
                }
                else
                {
                    nomComm = monLecteur["Nom"].ToString();
                }
                if (monLecteur["Rue"] == DBNull.Value)
                {
                    rueComm = default(string);
                }
                else
                {
                    rueComm = monLecteur["Nom"].ToString();
                }
                if (monLecteur["Telephone"] == DBNull.Value)
                {
                    telephoneComm = default(string);
                }
                else
                {
                    telephoneComm = monLecteur["Telephone"].ToString();
                }
                if (monLecteur["Mail"] == DBNull.Value)
                {
                    mailComm = default(string);
                }
                else
                {
                    mailComm = monLecteur["Mail"].ToString();
                }
                if (monLecteur["Site"] == DBNull.Value)
                {
                    siteComm = default(string);
                }
                else
                {
                    siteComm = monLecteur["Site"].ToString();
                }
                if (monLecteur["Ville"] == DBNull.Value)
                {
                    ville = default(string);
                }
                else
                {
                    ville = monLecteur["Ville"].ToString();
                }

                uneVille = new Ville(ville);
                uneComm= new Communication(nomComm, rueComm, telephoneComm, mailComm, siteComm, ville)

            }
        }
    }
}
