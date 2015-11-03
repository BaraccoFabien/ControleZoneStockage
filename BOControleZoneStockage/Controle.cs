using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOControleZoneStockage
{
    public class Controle
    {
        private int idTypeControle;
        private DateTime dateControle;
        private string resumeControle;
        private float  montantHTControle;
        private int idEntreprise;
        private int idZoneStockage;

        public Controle(int idTypeControle, DateTime dateControle,string resumeControle, float montantHTControle, int idEntreprise, int idZoneStockage)
        {
            this.idEntreprise = idEntreprise;
            this.idZoneStockage = idZoneStockage;
            this.idTypeControle = idTypeControle;
            this.dateControle = dateControle;
            this.resumeControle = resumeControle;
            this.montantHTControle = montantHTControle;
        }

        public int IdZoneStockage
        {
            get { return idZoneStockage; }
            set { idZoneStockage = value; }
        }

        public int IdEntreprise
        {
            get { return idEntreprise; }
            set { idEntreprise = value; }
        }


        public float MontantHTControle
        {
            get { return montantHTControle; }
            set { montantHTControle = value; }
        }

        public string ResumeControle
        {
            get { return resumeControle; }
            set { resumeControle = value; }
        }

        public DateTime DateControle
        {
            get { return dateControle; }
            set { dateControle = value; }
        }

        public int IdControle
        {
            get { return idControle; }
            set { idControle = value; }
        }

    }
}
