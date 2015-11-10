using BOControleZoneStockage;
using DALControleZoneStockage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLControleZoneStockage
{
    public class ManagerEntreprise
    {
        private static ManagerEntreprise leManagerEntreprise;

        public static ManagerEntreprise GetInstanceManagerEntreprise()
        {
            if (leManagerEntreprise==null)
            {
                leManagerEntreprise = new ManagerEntreprise();
            }
            return leManagerEntreprise;
        }

        private ManagerEntreprise ()
        {

        }

        public List<Entreprise> GetEntrepriseHabiliterPourUnTypeControle(int idTypeControle)
        {
            return DAOEntreprise.GetInstanceDAOEntreprise().SelectEntrepriseHabiliterPourUnTypeControle(idTypeControle);
        }

        public List<Entreprise> GetEntreprise(int idEntreprise)
        {
            return DAOEntreprise.GetInstanceDAOEntreprise().GetEntreprise(idEntreprise);
        }
    }
}
