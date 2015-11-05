namespace ControleZoneStockage
{
    partial class FrmEnregistrerControle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbZoneStockage = new System.Windows.Forms.Label();
            this.lbTypeControle = new System.Windows.Forms.Label();
            this.lbEntreprise = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbxStockage = new System.Windows.Forms.ComboBox();
            this.cbxTypeControle = new System.Windows.Forms.ComboBox();
            this.cbxEntreprise = new System.Windows.Forms.ComboBox();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.btnEnregControle = new System.Windows.Forms.Button();
            this.pnlTypeControle = new System.Windows.Forms.Panel();
            this.pnlEntreprise = new System.Windows.Forms.Panel();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.pnlTypeControle.SuspendLayout();
            this.pnlEntreprise.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbZoneStockage
            // 
            this.lbZoneStockage.AutoSize = true;
            this.lbZoneStockage.Location = new System.Drawing.Point(20, 54);
            this.lbZoneStockage.Name = "lbZoneStockage";
            this.lbZoneStockage.Size = new System.Drawing.Size(107, 13);
            this.lbZoneStockage.TabIndex = 0;
            this.lbZoneStockage.Text = "Zones de Stockage :";
            // 
            // lbTypeControle
            // 
            this.lbTypeControle.AutoSize = true;
            this.lbTypeControle.Location = new System.Drawing.Point(11, 6);
            this.lbTypeControle.Name = "lbTypeControle";
            this.lbTypeControle.Size = new System.Drawing.Size(93, 13);
            this.lbTypeControle.TabIndex = 1;
            this.lbTypeControle.Text = "Type de controle :";
            // 
            // lbEntreprise
            // 
            this.lbEntreprise.AutoSize = true;
            this.lbEntreprise.Location = new System.Drawing.Point(44, 6);
            this.lbEntreprise.Name = "lbEntreprise";
            this.lbEntreprise.Size = new System.Drawing.Size(60, 13);
            this.lbEntreprise.TabIndex = 2;
            this.lbEntreprise.Text = "Entreprise :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(3, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date :";
            // 
            // cbxStockage
            // 
            this.cbxStockage.FormattingEnabled = true;
            this.cbxStockage.Location = new System.Drawing.Point(133, 51);
            this.cbxStockage.Name = "cbxStockage";
            this.cbxStockage.Size = new System.Drawing.Size(121, 21);
            this.cbxStockage.TabIndex = 4;
            this.cbxStockage.SelectedIndexChanged += new System.EventHandler(this.cbxStockage_SelectedIndexChanged);
            // 
            // cbxTypeControle
            // 
            this.cbxTypeControle.FormattingEnabled = true;
            this.cbxTypeControle.Location = new System.Drawing.Point(110, 3);
            this.cbxTypeControle.Name = "cbxTypeControle";
            this.cbxTypeControle.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeControle.TabIndex = 5;
            // 
            // cbxEntreprise
            // 
            this.cbxEntreprise.FormattingEnabled = true;
            this.cbxEntreprise.Location = new System.Drawing.Point(110, 3);
            this.cbxEntreprise.Name = "cbxEntreprise";
            this.cbxEntreprise.Size = new System.Drawing.Size(121, 21);
            this.cbxEntreprise.TabIndex = 6;
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(47, 9);
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 7;
            // 
            // btnEnregControle
            // 
            this.btnEnregControle.Location = new System.Drawing.Point(133, 342);
            this.btnEnregControle.Name = "btnEnregControle";
            this.btnEnregControle.Size = new System.Drawing.Size(75, 23);
            this.btnEnregControle.TabIndex = 8;
            this.btnEnregControle.Text = "Enregistrer";
            this.btnEnregControle.UseVisualStyleBackColor = true;
            // 
            // pnlTypeControle
            // 
            this.pnlTypeControle.Controls.Add(this.lbTypeControle);
            this.pnlTypeControle.Controls.Add(this.cbxTypeControle);
            this.pnlTypeControle.Location = new System.Drawing.Point(23, 78);
            this.pnlTypeControle.Name = "pnlTypeControle";
            this.pnlTypeControle.Size = new System.Drawing.Size(285, 27);
            this.pnlTypeControle.TabIndex = 9;
            // 
            // pnlEntreprise
            // 
            this.pnlEntreprise.Controls.Add(this.lbEntreprise);
            this.pnlEntreprise.Controls.Add(this.cbxEntreprise);
            this.pnlEntreprise.Location = new System.Drawing.Point(23, 111);
            this.pnlEntreprise.Name = "pnlEntreprise";
            this.pnlEntreprise.Size = new System.Drawing.Size(285, 27);
            this.pnlEntreprise.TabIndex = 10;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.calDate);
            this.pnlDate.Controls.Add(this.lbDate);
            this.pnlDate.Location = new System.Drawing.Point(23, 143);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(285, 193);
            this.pnlDate.TabIndex = 11;
            // 
            // FrmEnregistrerControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 386);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlEntreprise);
            this.Controls.Add(this.pnlTypeControle);
            this.Controls.Add(this.btnEnregControle);
            this.Controls.Add(this.cbxStockage);
            this.Controls.Add(this.lbZoneStockage);
            this.Name = "FrmEnregistrerControle";
            this.Text = "Création d\'un Controle";
            this.pnlTypeControle.ResumeLayout(false);
            this.pnlTypeControle.PerformLayout();
            this.pnlEntreprise.ResumeLayout(false);
            this.pnlEntreprise.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbZoneStockage;
        private System.Windows.Forms.Label lbTypeControle;
        private System.Windows.Forms.Label lbEntreprise;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbxStockage;
        private System.Windows.Forms.ComboBox cbxTypeControle;
        private System.Windows.Forms.ComboBox cbxEntreprise;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Button btnEnregControle;
        private System.Windows.Forms.Panel pnlTypeControle;
        private System.Windows.Forms.Panel pnlEntreprise;
        private System.Windows.Forms.Panel pnlDate;
    }
}

