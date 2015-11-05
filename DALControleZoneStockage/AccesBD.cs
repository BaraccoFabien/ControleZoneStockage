using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DALControleZoneStockage
{
    public class AccesBD
    {
        private SqlConnection objConnex;
        private string laChaineDeConnexion;
        private static AccesBD uneInstance;

        //Retourne/modifie la chaine de connexion
        public string LaChaineDeConnexion
        {
            get { return laChaineDeConnexion; }
            set { laChaineDeConnexion = value; }
        }

        //Pour que seule la classe AccesBD puisse créer un objet de cette classe le constructeur est privé
        private AccesBD()
        {
            this.laChaineDeConnexion = ConfigurationManager.ConnectionStrings["BDControleZoneStockage"].ConnectionString;
        }

        //Singleton
        //Elle crée un objet instance de la classe AccesBD
        //Si l'objet n'existe pas puis retroune la ref a l'objet
        public static AccesBD GetInstance()
        {
            if (uneInstance==null)
            {
                uneInstance = new AccesBD();
            }
            return uneInstance;
        }
        //Obtient l'objet responsable de la connexion a la BDD

        public SqlConnection GetSqlConnexion()
        {
            if (objConnex == null)
            {
                objConnex = new SqlConnection();
            }

            objConnex.ConnectionString = laChaineDeConnexion;

            return objConnex;
        }

        public void CloseConnexion()
        {
            if (objConnex!=null && objConnex.State==System.Data.ConnectionState.Open)
            {
                objConnex.Close();
            }
        }
    }
}
