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

        public List<Controle> InsertControle(Controle MonControle)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<Controle> maListe = new List<Controle>();
            SqlCommand maCommande = new SqlCommand("sp_CreerControle", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idZoneStockage", SqlDbType.Int);
            maCommande.Parameters[0].Value = idControle;
            maCommande.Parameters.Add("idEntreprise", SqlDbType.Int);
            maCommande.Parameters[1].Value = idEntreprise;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[2].Value = idTypeControle;
            maCommande.Parameters.Add("dateControle", SqlDbType.Date);
            maCommande.Parameters[3].Value = dateControle;
            maCommande.Parameters.Add("resumeControle", SqlDbType.VarChar);
            maCommande.Parameters[4].Value = resumeControle;
            maCommande.Parameters.Add("montantHtControle", SqlDbType.Float);
            maCommande.Parameters[5].Value = montantHTControle;
            objConnexion.Open();
            maCommande.ExecuteNonQuery();
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }



    }
}
