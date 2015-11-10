﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOControleZoneStockage;
using System.Data;
using DALControleZoneStockage;


namespace BLLControleZoneStockage
{
    class ManagerHabilitation
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

        public void InsertHabilitationParEntreprise(int idEntreprise, int idTypeControl)
        {
            DAOHabilitation.GetInstanceDAOHabilitation().InsertHabilitationParEntreprise(idEntreprise, idTypeControl);
        }
    }

}
