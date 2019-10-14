using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data;
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
            Ville laVille;
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

                laVille = new Ville(ville);
                uneComm = new Communication(nomComm, rueComm, telephoneComm, mailComm, siteComm, laVille);

                lesComms.Add(uneComm);
            }
            monLecteur.Close();
            return lesComms;
        }

        public int AjoutComm(Communication uneComm)
        {
            string strSQL = "";
            int nbEnreg = 0;
            SqlConnection cnx = Connexion.GetObjConnexion();

            SqlCommand maCommande;
            maCommande = new SqlCommand("", cnx);

            strSQL = "insert into Communication values (@nom, @rue, @telephone, @mail, @site @ville)";
            maCommande.CommandText = strSQL;
            maCommande.Parameters.Add("nom", SqlDbType.VarChar);
            maCommande.Parameters[0].Value = uneComm.Nom;
            maCommande.Parameters.Add("rue", SqlDbType.VarChar);
            maCommande.Parameters[1].Value = uneComm.Rue;
            maCommande.Parameters.Add("telephone", SqlDbType.VarChar);
            maCommande.Parameters[2].Value = uneComm.Telephone;
            maCommande.Parameters.Add("mail", SqlDbType.VarChar);
            maCommande.Parameters[3].Value = uneComm.Mail;
            maCommande.Parameters.Add("site", SqlDbType.VarChar);
            maCommande.Parameters[4].Value = uneComm.Site;
            maCommande.Parameters.Add("ville", SqlDbType.Int);
            maCommande.Parameters[5].Value = uneComm.LaVille.Id;

            nbEnreg = maCommande.ExecuteNonQuery();
            return nbEnreg;

        }
    }
}
