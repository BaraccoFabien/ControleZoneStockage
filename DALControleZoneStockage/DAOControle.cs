using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
