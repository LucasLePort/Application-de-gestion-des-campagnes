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
    public class AgenceDAO
    {
        private static AgenceDAO uneInstance;

        public static AgenceDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AgenceDAO();
            }
            return uneInstance;
        }

        private AgenceDAO()
        {

        }

        public List<Agence> GetAgences()
        {
            int idAgence;
            string nomAgence;
            string rueAgence;
            string telephoneAgence;
            string mailAgence;
            string siteAgence;
            string ville;
            string typeAgence;
            Agence uneAgence;
            Ville laVille;


            SqlConnection cnx = Connexion.GetObjConnexion();

            //création de la collection lesClients qui va contenir les caractéristiques de tous les clients
            List<Agence> lesAgences = new List<Agence>();
            List<Ville> lesVilles = new List<Ville>();

            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.CommandText = "obtenirtouteslesagences";

            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {
                if (monLecteur["IdAgence"] == DBNull.Value)
                {
                    idAgence = default(int);
                }
                else
                {
                    idAgence = (int)monLecteur["IdAgence"];
                }
                if (monLecteur["Nom"] == DBNull.Value)
                {
                    nomAgence = default(string);
                }
                else
                {
                    nomAgence = monLecteur["Nom"].ToString();
                }
                if (monLecteur["Rue"] == DBNull.Value)
                {
                    rueAgence = default(string);
                }
                else
                {
                    rueAgence = monLecteur["Rue"].ToString();
                }
                if (monLecteur["Telephone"] == DBNull.Value)
                {
                    telephoneAgence = default(string);
                }
                else
                {
                    telephoneAgence = monLecteur["Telephone"].ToString();
                }
                if (monLecteur["Mail"] == DBNull.Value)
                {
                    mailAgence = default(string);
                }
                else
                {
                    mailAgence = monLecteur["Mail"].ToString();
                }
                if (monLecteur["Site"] == DBNull.Value)
                {
                    siteAgence = default(string);
                }
                else
                {
                    siteAgence = monLecteur["Site"].ToString();
                }
                if (monLecteur["ville"] == DBNull.Value)
                {
                    ville = default(string);
                }
                else
                {
                    ville = monLecteur["ville"].ToString();
                }
                if(monLecteur["TypeAgence"]==DBNull.Value)
                {
                    typeAgence = default(string);
                }
                else
                {
                    typeAgence = monLecteur["TypeAgence"].ToString();
                }

                laVille = new Ville(ville);
                uneAgence = new Agence(idAgence, nomAgence, rueAgence, telephoneAgence, mailAgence, siteAgence, laVille, typeAgence);

                lesAgences.Add(uneAgence);
            }
            monLecteur.Close();
            return lesAgences;
        }
    }
}
