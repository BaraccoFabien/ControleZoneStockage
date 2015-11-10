using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOControleZoneStockage;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DALControleZoneStockage
{
    public class DAOHabilitation
    {
        private static DAOHabilitation uneInstanceHabilitation;

        public static DAOHabilitation GetInstanceDAOHabilitation()
        {
            if (uneInstanceHabilitation == null)
            {
                uneInstanceHabilitation = new DAOHabilitation();
            }
            return uneInstanceHabilitation;
        }

        public List<Habilititation> InsertHabilitationParEntreprise(Habilititation uneHabilitation)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<Habilititation> maListe = new List<Habilititation>();

            SqlCommand maCommande = new SqlCommand("sp_InsertHabilitation", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idEntreprise", SqlDbType.Int);
            maCommande.Parameters[0].Value = uneHabilitation.IdEntrepriseHabiliter;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[1].Value = uneHabilitation.IdTypeControlHabiliter;
            objConnexion.Open();
            maCommande.ExecuteNonQuery();
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }
    }
}
