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
    public class DAOControle
    {

        private static DAOControle uneInstanceDAOControle;

        public static DAOControle GetInstanceDAOControle()
        {
            if (uneInstanceDAOControle == null)
            {
                uneInstanceDAOControle = new DAOControle();
            }
            return uneInstanceDAOControle;
        }

        public List<Controle> InsertControle(int idControle, DateTime dateControle, string resumeControle, float montantHTControle)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<Controle> maListe = new List<Controle>();
            SqlCommand maCommande = new SqlCommand("sp_CreerControle", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[0].Value = idControle;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[1].Value = dateControle;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[2].Value = resumeControle;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[3].Value = montantHTControle;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[4].Value = montantHTControle;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[5].Value = montantHTControle;
            objConnexion.Open();
            maCommande.ExecuteNonQuery();
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }



    }
}
