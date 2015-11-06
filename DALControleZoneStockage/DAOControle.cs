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

        public List<Controle> InsertControle(Controle monControle)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<Controle> maListe = new List<Controle>();
            SqlCommand maCommande = new SqlCommand("sp_CreerControle", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idZoneStockage", SqlDbType.Int);
            maCommande.Parameters[0].Value = monControle.IdZoneStockage;
            maCommande.Parameters.Add("idEntreprise", SqlDbType.Int);
            maCommande.Parameters[1].Value = monControle.IdEntreprise;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[2].Value = monControle.IdTypeControle;
            maCommande.Parameters.Add("dateControle", SqlDbType.Date);
            maCommande.Parameters[3].Value = monControle.DateControle;
            maCommande.Parameters.Add("resumeControle", SqlDbType.VarChar);
            maCommande.Parameters[4].Value = monControle.ResumeControle;
            maCommande.Parameters.Add("montantHtControle", SqlDbType.Float);
            maCommande.Parameters[5].Value = monControle.MontantHTControle;
            objConnexion.Open();
            maCommande.ExecuteNonQuery();
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }



    }
}
