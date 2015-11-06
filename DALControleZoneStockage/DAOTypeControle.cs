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

        public List<TypeControle> GetTypeControle(int idTypeControl)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommande = new SqlCommand("sp_AfficherTypeControl", objConnexion);
            List<TypeControle> maListe = new List<TypeControle>();
            maCommande.CommandType = System.Data.CommandType.StoredProcedure;
            maCommande.Parameters.Add("idTypeControl", SqlDbType.Int);
            maCommande.Parameters[0].Value = idTypeControl;
            SqlDataReader monLecteur;

            objConnexion.Open();
            monLecteur = maCommande.ExecuteReader();
            while (monLecteur.Read())
            {
                TypeControle unTypeControl = new TypeControle((int)monLecteur["ID_TYPE_CONTROL"], (string)monLecteur["TYPE_CONTROL"]);
                maListe.Add(unTypeControl);
            }
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }
    }
}

