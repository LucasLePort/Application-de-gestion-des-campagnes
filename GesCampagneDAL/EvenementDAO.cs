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
    public class EvenementDAO
    {
        private static EvenementDAO uneInstance;

        public static EvenementDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementDAO();
            }
            return uneInstance;
        }

        private EvenementDAO()
        {
        }

        public List<Evenement> GetEvenements()
        {
            string strSQL;
            string theme;
            string libelle;
            string libelleVille;
            string libelleEvent;
            int laVille;
            int leEvenementiel;
            DateTime dateDebut;
            DateTime dateFin;
            Evenement unEvenement;
            Evenementiel unEvenementiel;
            Ville uneVille;

            SqlConnection cnx = Connexion.GetObjConnexion();
            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;
            //création de la liste
            List<Evenement> lesEvenements = new List<Evenement>();
            List<Evenementiel> lesEvenementiels = new List<Evenementiel>();
            List<Ville> lesVilles = new List<Ville>();

            maCommande = new SqlCommand("", cnx);
            maCommande.CommandType = CommandType.StoredProcedure;
            strSQL = "obtenirDonneeEvenement";
            maCommande.CommandText = strSQL;
            // DataReader qui récupère les enregistrements
            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {
                // on récupère nom prenom de la table Client
                if (monLecteur["Theme"] == DBNull.Value)
                {
                    theme = default(string);
                }
                else
                {
                    theme = monLecteur["Theme"].ToString();
                }

                if (monLecteur["libellé"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["libellé"].ToString();
                }

                if (monLecteur["dateDebut"] == DBNull.Value)
                {
                    dateDebut = default(DateTime);
                }
                else
                {
                    dateDebut = (DateTime)monLecteur["dateDebut"];
                }

                if (monLecteur["dateFin"] == DBNull.Value)
                {
                    dateFin = default(DateTime);
                }
                else
                {
                    dateFin = (DateTime)monLecteur["dateFin"];
                }

                if (monLecteur["idVille"] == DBNull.Value)
                {
                    laVille = default(int);
                }
                else
                {
                    laVille = (int)monLecteur["idVille"];
                }

                if (monLecteur["idEvenementiel"] == DBNull.Value)
                {
                   leEvenementiel  = default(int);
                }
                else
                {
                    leEvenementiel = (int)monLecteur["idEvenementiel"];
                }

                if (monLecteur["villeLibelle"] == DBNull.Value)
                {
                    libelleVille = default(string);
                }
                else
                {
                    libelleVille = monLecteur["villeLibelle"].ToString();
                }
                if (monLecteur["NomEvent"] == DBNull.Value)
                {
                    libelleEvent = default(string);
                }
                else
                {
                    libelleEvent = monLecteur["NomEvent"].ToString();
                }

                unEvenementiel = new Evenementiel(leEvenementiel, libelleEvent);
                uneVille = new Ville(laVille, libelleVille);
                // on crée une instance de la classe Employe
                unEvenement = new Evenement(theme, libelle, dateDebut, dateFin, uneVille, unEvenementiel);
                // on ajoute l'instance créée dans la collection
                lesEvenements.Add(unEvenement);
            }
            monLecteur.Close();
            return lesEvenements;


        }
        public int AjoutEvenement(Evenement unEvenement)
        {
            string strSQL;
            int nbEnreg = 0;
            //on récupère l'objet responsable de la connexion à la base
            SqlConnection cnx = Connexion.GetObjConnexion();
            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            maCommande = new SqlCommand("", cnx);
            maCommande.CommandType = CommandType.StoredProcedure;
            strSQL = "ajouterevenement";
            maCommande.CommandText = strSQL;
            maCommande.Parameters.Add("theme", SqlDbType.VarChar);
            maCommande.Parameters[0].Value = unEvenement.Theme;
            maCommande.Parameters.Add("libelle", SqlDbType.VarChar);
            maCommande.Parameters[1].Value = unEvenement.Libelle;
            maCommande.Parameters.Add("dateDebut", SqlDbType.DateTime);
            maCommande.Parameters[2].Value = unEvenement.DateDebut;
            maCommande.Parameters.Add("dateFin", SqlDbType.DateTime);
            maCommande.Parameters[3].Value = unEvenement.DateFin;
            maCommande.Parameters.Add("idVille", SqlDbType.Int);
            maCommande.Parameters[4].Value = unEvenement.LaVille.Id;
            maCommande.Parameters.Add("idEvenementiel", SqlDbType.Int);
            maCommande.Parameters[5].Value = unEvenement.LeEvenementiel.Id;



            nbEnreg = maCommande.ExecuteNonQuery();
            return nbEnreg;
        }
    }
}

