using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOControleZoneStockage;
using System.Data.SqlClient;
using System.Data;
using BOControleZoneStockage;

namespace DALControleZoneStockage
{
    public class DAOEntreprise
    {
        private static DAOEntreprise uneInstanceDAOEntreprise;

        public static DAOEntreprise GetInstanceDAOEntreprise()
        {
            if (uneInstanceDAOEntreprise == null)
            {
                uneInstanceDAOEntreprise = new DAOEntreprise();
            }
            return uneInstanceDAOEntreprise;
        }

        public List<Entreprise> SelectEntrepriseHabiliterPourUnTypeControle(int idTypeControle)
        {
            SqlConnection objConnexion = AccesBD.GetInstance().GetSqlConnexion();
            List<Entreprise> maListe = new List<Entreprise>();
            SqlCommand maCommande = new SqlCommand("sp_SelectEntrepriseHabiliterPourUnTypeControle", objConnexion);
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.Parameters.Add("idTypeControle", SqlDbType.Int);
            maCommande.Parameters[0].Value = idTypeControle;
            objConnexion.Open();
            SqlDataReader lecteur = maCommande.ExecuteReader();
            while (lecteur.Read())
            {
                Entreprise uneEntreprise = new Entreprise((int)lecteur["ID_TYPE_CONTROLE"], (string)lecteur["TYPE_CONTROLE"]);
                maListe.Add(uneEntreprise);
            }
            AccesBD.GetInstance().CloseConnexion();
            return maListe;
        }
    }
}
