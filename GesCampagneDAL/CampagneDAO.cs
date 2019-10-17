using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCampagneDAL
{
    public class CampagneDAO
    {
        private static CampagneDAO uneInstance;

        public static CampagneDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new CampagneDAO();
            }
            return uneInstance;
        }

        private CampagneDAO()
        {

        }

        public List<Campagne> GetCampagnes()
        {
            int idLu;
            string intituleLu;
            string objectifLu;
            DateTime dateDebutLu;
            DateTime dateFinLu;
            int idEvenementielLu;
            string nomEvenementielLu;
            int idCommunicationLu;
            string nomCommunicationLu;
            int idCategPublicLu;
            string libelleCategPublicLu;

            Campagne uneCampagne;
            Communication uneCommunication;
            Evenementiel unEvenementiel;
            CategPublic uneCategPublic;
            string strSQL = "";

            SqlConnection cnx = Connexion.GetObjConnexion();

            //création des différentes collections
            List<Communication> lesCommunications = new List<Communication>();
            List<Evenementiel> lesEvenementiels = new List<Evenementiel>();
            List<CategPublic> lesCategsPublic = new List<CategPublic>();

            //création de l'objet de type SqlCommand
            SqlCommand maCommande;
            SqlDataReader monLecteur;

            maCommande = new SqlCommand("", cnx);

            strSQL = "select Campagne.id as 'idCampagne', intitule, objectif, dateDebut, dateFin,Evenementiel.id as 'idEvent', Evenementiel.nom as 'nomEvent'" +
                ", Communication.id as 'idComm', Communication.nom as 'nomComm', CategPublic.id_ as 'idCatPublic', CategPublic.libelle as 'libCatPublic'" +
                "from Campagne " +
                "join Evenementiel on id_Evenementiel=Evenementiel.id " +
                "join Communication on id_Communication=Communication.id" +
                "join CategPublic on id_CategPublic=CategPublic.id";
            maCommande.CommandText = strSQL;

            monLecteur = maCommande.ExecuteReader();

            while (monLecteur.Read())
            {
                if (monLecteur["idCampagne"] == DBNull.Value)
                {
                    idLu = default(int);
                }
                else
                {
                    idLu = (int)monLecteur["idCampagne"];
                }
                if (monLecteur["intitule"] == DBNull.Value)
                {
                    intituleLu = default(string);
                }
                else
                {
                    intituleLu = monLecteur["intitule"].ToString();
                }
                if (monLecteur["objectif"] == DBNull.Value)
                {
                    objectifLu = default(string);
                }
                else
                {
                    objectifLu = monLecteur["objectif"].ToString();
                }
                if (monLecteur["dateDebut"] == DBNull.Value)
                {
                    dateDebutLu = default(DateTime);
                }
                else
                {
                    dateDebutLu = (DateTime)monLecteur["dateDebut"];
                }
                if (monLecteur["dateFin"] == DBNull.Value)
                {
                    dateFinLu = default(DateTime);
                }
                else
                {
                    dateFinLu = (DateTime)monLecteur["dateFin"];
                }
                if (monLecteur["idEvent"] == DBNull.Value)
                {
                    idEvenementielLu = default(int);
                }
                else
                {
                    idEvenementielLu = (int)monLecteur["idEvent"];
                }
                if (monLecteur["nomEvent"] == DBNull.Value)
                {
                    nomEvenementielLu = default(string);
                }
                else
                {
                    nomEvenementielLu = monLecteur["nomEvent"].ToString();
                }
                if (monLecteur["idComm"] == DBNull.Value)
                {
                    idCommunicationLu = default(int);
                }
                else
                {
                    idCommunicationLu = (int)monLecteur["idComm"];
                }
                if (monLecteur["nomComm"] == DBNull.Value)
                {
                    nomCommunicationLu = default(string);
                }
                else
                {
                    nomCommunicationLu = monLecteur["nomComm"].ToString();
                }
                if (monLecteur["idCatPublic"] == DBNull.Value)
                {
                    idCategPublicLu = default(int);
                }
                else
                {
                    idCategPublicLu = (int)monLecteur["idCatPublic"];
                }
                if (monLecteur["libCatPublic"] == DBNull.Value)
                {
                    libelleCategPublicLu = default(string);
                }
                else
                {
                    libelleCategPublicLu = monLecteur["libCatPublic"].ToString();
                }

                unEvenementiel = new Evenementiel(idEvenementielLu, nomEvenementielLu);
                uneCommunication = new Communication(idCommunicationLu, nomCommunicationLu);
                uneCategPublic = new CategPublic(idCategPublicLu, libelleCategPublicLu);
                uneCampagne = new Campagne(idLu, intituleLu, objectifLu, dateDebutLu, dateFinLu, uneCommunication, unEvenementiel, uneCategPublic);

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
