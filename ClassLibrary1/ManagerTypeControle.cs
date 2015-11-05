using DALControleZoneStockage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BOControleZoneStockage;

namespace BLLControleZoneStockage
{
    class ManagerTypeControle
    {
        private static ManagerTypeControle uneInstanceManagerTypeControle;

        private ManagerTypeControle()
        {

        }

        public static ManagerTypeControle GetInstanceManagerTypeControlee()
        {
            if (uneInstanceManagerTypeControle == null)
            {
                uneInstanceManagerTypeControle = new ManagerTypeControle();
            }
            return uneInstanceManagerTypeControle;
        }

        public void SetChaineConnexion(ConnectionStringSettings connString)
        {
            string laChaine = connString.ConnectionString;
            AccesBD.GetInstance().LaChaineDeConnexion = laChaine;
        }

        public List<TypeControle> GetTypesControle(int idZoneStockage)
        {
           return DAOTypeControle.GetInstanceDAOTypeControle().SelectTypeControlePrevuePourUneZoneStockage(idZoneStockage);
        }

        public List<TypeControle> GetToutTypeDeControl()
        {
            return DAOTypeControle.GetInstanceDAOTypeControle().//Creer sp_AfficherTypeControl
        }
    }
}
