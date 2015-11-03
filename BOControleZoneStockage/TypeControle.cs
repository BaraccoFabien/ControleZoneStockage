using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOControleZoneStockage
{
    public class TypeControle
    {
        private int idTypeControle;
        private string libelleTypeControle;

        public string LibelleTypeControle
        {
            get { return libelleTypeControle; }
            set { libelleTypeControle = value; }
        }

        public TypeControle(int idTypeControle, string libelleTypeControle)
        {
            this.idTypeControle = idTypeControle;
            this.libelleTypeControle = libelleTypeControle;
        }

        public int IdTypeControle
        {
            get { return idTypeControle; }
            set { idTypeControle = value; }
        }
    }
}
