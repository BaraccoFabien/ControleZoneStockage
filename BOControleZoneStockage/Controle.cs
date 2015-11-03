using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOControleZoneStockage
{
    public class Controle
    {
        private int idControle;
        private DateTime dateControle;
        private string resumeControle;
        private float  montantHTControle;

        public Controle(int idControle, DateTime dateControle,string resumeControle, float montantHTControle)
        {
            this.idControle = idControle;
            this.dateControle = dateControle;
            this.resumeControle = resumeControle;
            this.montantHTControle = montantHTControle;
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
