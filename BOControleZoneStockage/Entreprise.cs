using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOControleZoneStockage
{
    public class Entreprise
    {
        private int idEntreprise;
        private string nomEntreprise;
        private string adresseEntreprise;
        private string mailEntreprise;

        public Entreprise(int unIdEntreprise, string unNomEntreprise, string uneAdresseEntreprise, string unMailEntreprise)
        {
            idEntreprise = unIdEntreprise;
            nomEntreprise = unNomEntreprise;
            adresseEntreprise = uneAdresseEntreprise;
            mailEntreprise = unMailEntreprise;
        }

        public int IdEntreprise
        {
            get { return idEntreprise; }
            set { idEntreprise = value; }
        }


        public string NomEntreprise
        {
            get { return nomEntreprise; }
            set { nomEntreprise = value; }
        }



        public string AdresseEntreprise
        {
            get { return adresseEntreprise; }
            set { adresseEntreprise = value; }
        }



        public string MailEntreprise
        {
            get { return mailEntreprise; }
            set { mailEntreprise = value; }
        }

    }
}
