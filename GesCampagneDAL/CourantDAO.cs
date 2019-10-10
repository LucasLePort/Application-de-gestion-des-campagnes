using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    class CourantDAO
    {
        private SqlCommand maCommand;
        private static CourantDAO uneInstance;
        public static CourantDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CourantDAO();
            }
            return uneInstance;
        }

        private CourantDAO()
        {

        }
        public List<Courant> GetCategSocioPro()
        {
            // déclaration des variables de travail
            int idLu;
            string libelleLu;


            // on récupère l'objet responsable de la connexion à la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            SqlDataReader monLecteur;

            List<Courant> lesCourant;
            lesCourant = new List<Courant>();
            maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandText = "select id, libelle from Courant";

            // execution de la requête 

            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                // on recupere le nom et le prenom du client
                idLu = (int)monLecteur["id"];
                libelleLu = (string)monLecteur["libelle"];

                // on cree une instance de la classe CategSocioPro
                Courant unCourant = new Courant(idLu, libelleLu);

                // on ajoute l'instance créée dans la collection
                lesCourant.Add(unCourant);

            }

            monLecteur.Close();
            Connexion.CloseConnection();
            return lesCourant;
        }
    }
}
