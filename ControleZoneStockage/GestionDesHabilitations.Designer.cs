namespace ControleZoneStockage
{
    partial class GestionDesHabilitations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectEntreprise = new System.Windows.Forms.Label();
            this.lblTypeDeControl = new System.Windows.Forms.Label();
            this.cbxListeEntreprise = new System.Windows.Forms.ComboBox();
            this.cbxListeTypeControl = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectEntreprise
            // 
            this.lblSelectEntreprise.AutoSize = true;
            this.lblSelectEntreprise.Location = new System.Drawing.Point(36, 33);
            this.lblSelectEntreprise.Name = "lblSelectEntreprise";
            this.lblSelectEntreprise.Size = new System.Drawing.Size(157, 13);
            this.lblSelectEntreprise.TabIndex = 0;
            this.lblSelectEntreprise.Text = "Choisissez l\'entreprise à habiliter";
            // 
            // lblTypeDeControl
            // 
            this.lblTypeDeControl.AutoSize = true;
            this.lblTypeDeControl.Location = new System.Drawing.Point(39, 111);
            this.lblTypeDeControl.Name = "lblTypeDeControl";
            this.lblTypeDeControl.Size = new System.Drawing.Size(169, 13);
            this.lblTypeDeControl.TabIndex = 1;
            this.lblTypeDeControl.Text = "Choisissez l\'habilitation a attribuer :";
            // 
            // cbxListeEntreprise
            // 
            this.cbxListeEntreprise.FormattingEnabled = true;
            this.cbxListeEntreprise.Location = new System.Drawing.Point(256, 33);
            this.cbxListeEntreprise.Name = "cbxListeEntreprise";
            this.cbxListeEntreprise.Size = new System.Drawing.Size(121, 21);
            this.cbxListeEntreprise.TabIndex = 2;
            // 
            // cbxListeTypeControl
            // 
            this.cbxListeTypeControl.FormattingEnabled = true;
            this.cbxListeTypeControl.Location = new System.Drawing.Point(256, 102);
            this.cbxListeTypeControl.Name = "cbxListeTypeControl";
            this.cbxListeTypeControl.Size = new System.Drawing.Size(121, 21);
            this.cbxListeTypeControl.TabIndex = 3;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(192, 189);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 23);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // GestionDesHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbxListeTypeControl);
            this.Controls.Add(this.cbxListeEntreprise);
            this.Controls.Add(this.lblTypeDeControl);
            this.Controls.Add(this.lblSelectEntreprise);
            this.Name = "GestionDesHabilitations";
            this.Text = "GestionDesHabilitations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectEntreprise;
        private System.Windows.Forms.Label lblTypeDeControl;
        private System.Windows.Forms.ComboBox cbxListeEntreprise;
        private System.Windows.Forms.ComboBox cbxListeTypeControl;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}