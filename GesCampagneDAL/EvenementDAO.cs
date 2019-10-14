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

            strSQL = "select theme, libelle, dateDebut, dateFin, Ville.id as 'idVille', Evenementiel.id as 'idEvenementiel' from Evenement join Ville on idVille = id.Ville join Evenementiel on idEvenementiel = Evenementiel.id";
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

                if (monLecteur["Libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monLecteur["Libelle"].ToString();
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


                unEvenementiel = new Evenementiel(leEvenementiel);
                uneVille = new Ville(laVille);
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
            strSQL = "insert into Evenement values(@theme,@libelle, @dateDebut, @dateFin, @idVille , @idEvenementiel)";
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


            nbEnreg = maCommande.ExecuteNonQuery();
            return nbEnreg;
        }
        public int ModifClient(Client unClient)
        {
            string strSQL;
            int nbEnreg = 0;
            //on récupère l'objet responsable de la connexion à la base
            SqlConnection cnx = Connexion.GetObjConnexion();
            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            maCommande = new SqlCommand("", cnx);

            strSQL = "update table Client set nom=@nom, prenom=@prenom,idCategSocioPro=@categ where Client.id = @idCli";
            maCommande.CommandText = strSQL;
            maCommande.Parameters.Add("nom", SqlDbType.VarChar);
            maCommande.Parameters[0].Value = unClient.Nom;
            maCommande.Parameters.Add("prenom", SqlDbType.VarChar);
            maCommande.Parameters[1].Value = unClient.Prenom;
            maCommande.Parameters.Add("categ", SqlDbType.Int);
            maCommande.Parameters[2].Value = unClient.LaCateg.Id;
            maCommande.Parameters.Add("idCli", SqlDbType.Int);
            maCommande.Parameters[3].Value = unClient.Id;

            maCommande.Parameters.Add("idEvenementiel", SqlDbType.Int);
            maCommande.Parameters[4].Value = unEvenement.LeEvenementiel.Id;



            nbEnreg = maCommande.ExecuteNonQuery();
            return nbEnreg;

        }

        }
    }
}
