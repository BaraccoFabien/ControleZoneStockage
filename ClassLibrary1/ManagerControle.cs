using BOControleZoneStockage;
using DALControleZoneStockage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLControleZoneStockage
{
    class ManagerControle
    {
        private static ManagerControle monManager;

        public static ManagerControle GetInstanceManagerControle()
        {
            if (monManager==null)
            {
                monManager = new ManagerControle();
            }
            return monManager;
        }

        private ManagerControle()
        {

        }

        public void CreerControle ( Controle monControle)
        {
            DAOControle.GetInstanceDAOControle().InsertControle(monControle);
        }
    }
}
