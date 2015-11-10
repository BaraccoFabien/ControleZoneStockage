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

        public List<Habilititation> InsertHabilitationParEntreprise(int idEntreprise, int idTypeControl)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<TypeControle> maListeTypeControle = new List<TypeControle>();
            List<Entreprise> maLIsteEntreprise = new List<Entreprise>();

            SqlCommand maCommande = new SqlCommand("sp_InsertHabilitation", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idEntreprise", SqlDbType.Int);
            maCommande.Parameters[0].Value = idEntreprise;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[1].Value = idTypeControl;
            objConnexion.Open();
            maCommande.ExecuteNonQuery();
            AccesBD.GetInstance().CloseConnexion();
    }
}
