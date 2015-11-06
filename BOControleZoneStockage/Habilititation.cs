using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOControleZoneStockage
{
    public class Habilititation
    {

        private int idEntrepriseHabiliter;
        private int idTypeControlHabiliter;

        public int IdEntrepriseHabiliter
        {
            get { return idEntrepriseHabiliter; }
            set { idEntrepriseHabiliter = value; }
        }
        
        public int IdTypeControlHabiliter
        {
            get { return idTypeControlHabiliter; }
            set { idTypeControlHabiliter = value; }
        }

        public Habilititation(int unIdEntrepriseHabiliter, int unIdTypeControlHabiliter)
        {
            idEntrepriseHabiliter = unIdEntrepriseHabiliter;
            IdTypeControlHabiliter = unIdTypeControlHabiliter;
        }

    }
}
