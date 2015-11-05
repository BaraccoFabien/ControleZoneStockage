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

        public static DAOHabilitation GetInstanceDAOTypeControle()
        {
            if (uneInstanceHabilitation == null)
            {
                uneInstanceHabilitation = new DAOHabilitation();
            }
            return uneInstanceHabilitation;
        }

        public void InsertHabilitationParEntreprise(int idEntreprise, int idTypeDeControl)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().OpenConnexion();
            List<TypeControle> maListeTypeControle = new List<TypeControle>();
            List<Entreprise> maLIsteEntreprise = new List<Entreprise>();

            SqlCommand maCommande = new SqlCommand("sp_InsertHabilitation", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idEntreprise", SqlDbType.Int);
            maCommande.Parameters[0].Value = idEntreprise;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[1].Value = idTypeDeControl;
            objConnexion.Open();
            SqlDataReader lecteur = maCommande.ExecuteReader();
        }
    }
}
