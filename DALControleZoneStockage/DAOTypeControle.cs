using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOControleZoneStockage;
using System.Data.SqlClient;
using System.Data;

namespace DALControleZoneStockage
{
    public class DAOTypeControle
    {
        private static DAOTypeControle uneInstanceTypeControle;

        public static DAOTypeControle GetInstanceDAOTypeControle()
        {
            if (uneInstanceTypeControle==null)
            {
                uneInstanceTypeControle = new DAOTypeControle();
            }
            return uneInstanceTypeControle;
        }

        public List<TypeControle>SelectTypeControlePrevuePourUneZoneStockage(int idZoneStockage)
        {
            SqlConnection objConnexion=AccesBD.GetInstance().GetSqlConnexion();
            List<TypeControle> maListe = new List<TypeControle>();
            SqlCommand maCommande = new SqlCommand("sp_SelectTypePrevuePourZoneStockage", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idZoneStockage", SqlDbType.Int);
            maCommande.Parameters[0].Value = idZoneStockage;
            objConnexion.Open();
            SqlDataReader lecteur=maCommande.ExecuteReader();
            while (lecteur.Read())
            {
                TypeControle unTypeControle = new TypeControle((int)lecteur["ID_TYPE_CONTROLE"], (string)lecteur["TYPE_CONTROLE"]);
                maListe.Add(unTypeControle);
            }
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }

        public List<TypeControle> GetTypeControle()
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommande = new SqlCommand("sp_AficherLesTypesDeControle", objConnexion);
            List<TypeControle> maListe = new List<TypeControle>();
            
            SqlDataReader monLecteur;

            maCommande.Parameters.Clear();
            maCommande.CommandType = System.Data.CommandType.StoredProcedure;
            objConnexion.Open();
            monLecteur = maCommande.ExecuteReader();
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }
    }
}

