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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnEnregControle = new System.Windows.Forms.Button();
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
            this.lbTypeControle.Location = new System.Drawing.Point(34, 81);
            this.lbTypeControle.Name = "lbTypeControle";
            this.lbTypeControle.Size = new System.Drawing.Size(93, 13);
            this.lbTypeControle.TabIndex = 1;
            this.lbTypeControle.Text = "Type de controle :";
            // 
            // lbEntreprise
            // 
            this.lbEntreprise.AutoSize = true;
            this.lbEntreprise.Location = new System.Drawing.Point(67, 108);
            this.lbEntreprise.Name = "lbEntreprise";
            this.lbEntreprise.Size = new System.Drawing.Size(60, 13);
            this.lbEntreprise.TabIndex = 2;
            this.lbEntreprise.Text = "Entreprise :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(20, 156);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(133, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(70, 156);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
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
            // FrmEnregistrerControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 386);
            this.Controls.Add(this.btnEnregControle);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbEntreprise);
            this.Controls.Add(this.lbTypeControle);
            this.Controls.Add(this.lbZoneStockage);
            this.Name = "FrmEnregistrerControle";
            this.Text = "Création d\'un Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbZoneStockage;
        private System.Windows.Forms.Label lbTypeControle;
        private System.Windows.Forms.Label lbEntreprise;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnEnregControle;
    }
}

