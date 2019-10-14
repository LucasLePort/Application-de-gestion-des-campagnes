using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class VilleDAO
    {
        private static VilleDAO uneInstance;

        //cette méthode crée un objet de la classe VilleDAO s'il n'existe pas déja un
        //puis retourne la référence à cet objet
        public static VilleDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleDAO();
            }
            return uneInstance;
        }
        //le constructeur par défaut est privé: il ne sera pas possible de créer un
        //objet à l'extérieur de la classe avec l'instruction new...
        private VilleDAO()
        {

        }

        //la méthode GetClients retourne une collection contenant les clients
        //existant dans la table Client
        public List<Ville> GetVilles()
        {
            int idVille;
            string libelleVille;
            string strSQL = "";
            Ville uneVille;
            //on récupère l'objet responsable de la connexion à la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //création de la collection lesClients qui va contenir les caractéristiques de tous les clients
            List<Ville> lesVilles = new List<Ville>();

            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

            strSQL = "select id, libelle from Ville";
            maCommande.CommandText = strSQL;

            //DataReader qui récupère les enregistrements
            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {

                //on récup les données du client
                if (monLecteur["Id"] == DBNull.Value)
                {
                    idVille = default(int);
                }
                else
                {
                    idVille = (int)monLecteur["Id"];
                }
                if (monLecteur["Libelle"] == DBNull.Value)
                {
                    libelleVille = default(string);
                }
                else
                {
                    libelleVille = monLecteur["Libelle"].ToString();
                }
                //on créer une instance de la classe Client
                uneVille = new Ville(idVille, libelleVille);

                //on ajoute  dans la collection
                lesVilles.Add(uneVille);
            }
            monLecteur.Close();
            return lesVilles;
        }
    }
}
