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
    public class ManagerTypeControle
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



        public List<TypeControle> GetTypeControlePrevuePourUneZoneStockage(int idZoneStockage)
        {
           return DAOTypeControle.GetInstanceDAOTypeControle().SelectTypeControlePrevuePourUneZoneStockage(idZoneStockage);
        }


    }
}
