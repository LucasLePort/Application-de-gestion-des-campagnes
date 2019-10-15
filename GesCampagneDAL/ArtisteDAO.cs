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
            string siteLu;
            int idCourantLu;
            string CourantLibelleLu;
            SqlConnection cnx = Connexion.GetObjConnexion();
            Courant unCourant;
            SqlDataReader monLecteur;

            List<Artiste> lesArtistes;
            lesArtistes = new List<Artiste>();
            maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandText = "select Artiste.id, nom, site, Courant.id as 'idCourant', Courant.libelle as 'libelleCourant' from Artiste join Courant on id_Courant = Courant.id";

            // execution de la requete

            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                idLu = (int)monLecteur["id"];
                nomLu = (string)monLecteur["nom"];
                siteLu = (string)monLecteur["site"];
                idCourantLu = (int)monLecteur["idCourant"];
                CourantLibelleLu = (string)monLecteur["libelleCourant"];

                unCourant = new Courant(idCourantLu, CourantLibelleLu);

                // on cree une instance de la classe Artiste
                Artiste unArtiste = new Artiste(idLu, nomLu, siteLu, unCourant);

                // on ajoute l'instance créée dans la collection
                lesArtistes.Add(unArtiste);
            }
            monLecteur.Close();
            Connexion.CloseConnection();
            return lesArtistes;
        }

        public int AjoutArtiste(Artiste unArtiste)
        {
            string nomArtiste;
            string site;
            int nbAjout = 0;
            int idCourant = 0;
            // on récupère l'objet responsable de la connexion à la base
            SqlConnection cnx = Connexion.GetObjConnexion();
            maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            // requête SQL execution
            maCommand.CommandText = "INSERT INTO Client(nom, site, id_Courant) VALUES (@nom, @site,@idCourant)";

            nomArtiste = unArtiste.Nom;
            site = unArtiste.Site;
            idCourant = unArtiste.LeCourant.Id;

            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("site", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("id_Courant", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = nomArtiste;
            maCommand.Parameters[1].Value = site;
            maCommand.Parameters[2].Value = idCourant;


            nbAjout = maCommand.ExecuteNonQuery();

            return nbAjout;
        }


    }

}
