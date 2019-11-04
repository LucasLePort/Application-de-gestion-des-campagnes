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
    public class EvenementielDAO
    {
        private static EvenementielDAO uneInstance;

        public static EvenementielDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementielDAO();
            }
            return uneInstance;
        }

        private EvenementielDAO()
        {

        }

        public List<Evenementiel>GetEvenementiels ()
        {
            string nomComm;
            string rueComm;
            string telephoneComm;
            string mailComm;
            string siteComm;
            string ville;
            int idEvenementiel;
            Evenementiel unEvent;
            Ville laVille;

            SqlConnection cnx = Connexion.GetObjConnexion();

            //création de la collection lesClients qui va contenir les caractéristiques de tous les clients
            List<Evenementiel> lesEvents = new List<Evenementiel>();
            List<Ville> lesVilles = new List<Ville>();

            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.CommandText = "obtenirlesagencesevenementiel";

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
                if(monLecteur["eventID"] == DBNull.Value)
                {
                    idEvenementiel = default(int);
                }
                else
                {
                    idEvenementiel = (int)monLecteur["eventID"];
                }

                laVille = new Ville(ville);
                unEvent = new Evenementiel(idEvenementiel, nomComm, rueComm, telephoneComm, mailComm, siteComm, laVille);

                lesEvents.Add(unEvent);
            }
            monLecteur.Close();
            return lesEvents;
        }

        public int AjoutEvent(Evenementiel unEvent)
        {
            string strSQL = "";
            int nbEnreg = 0;
            SqlConnection cnx = Connexion.GetObjConnexion();

            SqlCommand maCommande;
            maCommande = new SqlCommand("", cnx);

            strSQL = "insert into Evenementiel values (@nom, @rue, @telephone, @mail, @site, @ville)";
            maCommande.CommandText = strSQL;
            maCommande.Parameters.Add("nom", SqlDbType.VarChar);
            maCommande.Parameters[0].Value = unEvent.Nom;
            maCommande.Parameters.Add("rue", SqlDbType.VarChar);
            maCommande.Parameters[1].Value = unEvent.Rue;
            maCommande.Parameters.Add("telephone", SqlDbType.VarChar);
            maCommande.Parameters[2].Value = unEvent.Telephone;
            maCommande.Parameters.Add("mail", SqlDbType.VarChar);
            maCommande.Parameters[3].Value = unEvent.Mail;
            maCommande.Parameters.Add("site", SqlDbType.VarChar);
            maCommande.Parameters[4].Value = unEvent.Site;
            maCommande.Parameters.Add("ville", SqlDbType.Int);
            maCommande.Parameters[5].Value = unEvent.LaVille.Id;

            nbEnreg = maCommande.ExecuteNonQuery();
            return nbEnreg;

        }
    }
}
