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
using System.Configuration;

namespace ControleZoneStockage
{
    public partial class GestionDesHabilitations : Form
    {
        public GestionDesHabilitations()
        {
            InitializeComponent();
        }

        private void cbxListeEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListeEntreprise.SelectedIndex == 0)
            {
                cbxListeEntreprise.DataSource = ManagerEntreprise.GetInstanceManagerEntreprise().GetEntreprise(Convert.ToInt32(cbxListeEntreprise.SelectedValue));
            }
        }

        private void cbxListeTypeControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxListeTypeControl.SelectedIndex == 0)
            {
                cbxListeTypeControl.DataSource = ManagerTypeControle.GetInstanceManagerTypeControle().GetTypeControle(Convert.ToInt32(cbxListeTypeControl.SelectedValue));
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(cbxListeEntreprise.SelectedIndex ==0)
            {
                MessageBox.Show("Veuillez choisir une entreprise à habiliter!");
            }
            if (cbxListeTypeControl.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez choisir une habilitation à attribuer!");
            }
            else
            {
                int idEntre = Convert.ToInt32(cbxListeEntreprise.SelectedValue);
                int idTypCtrl = Convert.ToInt32(cbxListeTypeControl.SelectedValue);

                Habilititation uneHabilitation = new Habilititation(idEntre,idTypCtrl);
            }

        }
    }
}
