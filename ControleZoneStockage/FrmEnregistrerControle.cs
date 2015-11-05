using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLControleZoneStockage;


namespace ControleZoneStockage
{
    public partial class FrmEnregistrerControle : Form
    {
        public FrmEnregistrerControle()
        {
            InitializeComponent();
            //Initialiser la comboBox avec toutes les zones de stockages
            ManagerAccesBD.GetInstanceManagerChaineConnexion().SetConnexionBD();

        }

        private void cbxStockage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStockage.SelectedIndex>=0)
            {
                cbxTypeControle.DataSource= ManagerTypeControle.GetInstanceManagerTypeControlee().GetTypesControle;
            }
        }
    }
}
