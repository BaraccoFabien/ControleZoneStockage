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
using BOControleZoneStockage;

namespace ControleZoneStockage
{
    public partial class FrmEnregistrerControle : Form
    {
        public FrmEnregistrerControle()
        {
            InitializeComponent();
            //Initialiser la comboBox avec toutes les zones de stockages

        }

        private void cbxStockage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStockage.SelectedIndex>=0)
            {
                cbxTypeControle.DataSource= ManagerTypeControle.GetInstanceManagerTypeControle().GetTypeControlePrevuePourUneZoneStockage(Convert.ToInt32(cbxStockage.SelectedValue));
                cbxTypeControle.Visible = true;
            }
        }

        private void cbxTypeControle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTypeControle.SelectedIndex >= 0)
            {
                cbxEntreprise.DataSource = ManagerEntreprise.GetInstanceManagerEntreprise().GetEntreprise(Convert.ToInt32(cbxTypeControle.SelectedValue));
                cbxEntreprise.Visible = true;
            }
        }

        private void cbxEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTypeControle.SelectedIndex >= 0)
            {
                calDate.Visible= true;
            }
        }

        private void btnEnregControle_Click(object sender, EventArgs e)
        {
           // Controle monControle = new Controle(Convert.ToInt32(cbxStockage.SelectedValue),calDate.SelectionStart.Date);
        }
    }
}
