using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class ArtisteDAO
    {
        private SqlCommand maCommand;
        private static ArtisteDAO uneInstance;

        public static ArtisteDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ArtisteDAO();
            }
            return uneInstance;
        }
        private ArtisteDAO()
        {

        }
        public List<Artiste> GetArtistes()
        {
            // déclaration des variables de travail
            int idLu;
            string nomLu;

            SqlConnection cnx = Connexion.GetObjConnexion();

            SqlDataReader monLecteur;

            List<Artiste> lesArtistes;
            lesArtistes = new List<Artiste>();
            maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandText = "select id, nom from Artiste";

            // execution de la requete

            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                idLu = (int)monLecteur["id"];
                nomLu = (string)monLecteur["nom"];

                // on cree une instance de la classe Artiste
                Artiste unArtiste = new Artiste(idLu, nomLu);

                // on ajoute l'instance créée dans la collection
                lesArtistes.Add(unArtiste);
            }
            monLecteur.Close();
            Connexion.CloseConnection();
            return lesArtistes;
        }



    }

}
