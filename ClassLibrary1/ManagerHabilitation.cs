using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOControleZoneStockage;
using System.Data;
using DALControleZoneStockage;


namespace BLLControleZoneStockage
{
   public class ManagerHabilitation
    {
        private static ManagerHabilitation uneInstanceManagerHabilitation;

        public static ManagerHabilitation GetInstanceManagerHabilitation()
        {
            if (uneInstanceManagerHabilitation == null)
            {
                uneInstanceManagerHabilitation = new ManagerHabilitation();
            } 
            return uneInstanceManagerHabilitation;
        }

        private ManagerHabilitation()
        {

        }

        public void InsertHabilitationParEntreprise(Habilititation uneHabilitation)
        {
            DAOHabilitation.GetInstanceDAOHabilitation().InsertHabilitationParEntreprise(uneHabilitation);
        }
    }

}
