
namespace Campagnes.GUI
{
    partial class FrmAjoutCampagne
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
            this.lblErreurs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtObjectif = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.cboAgenceCommu = new System.Windows.Forms.ComboBox();
            this.cboAgenceArtistique = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cboTypePublic = new System.Windows.Forms.ComboBox();
            this.cboEmploye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblErreurs
            // 
            this.lblErreurs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblErreurs.ForeColor = System.Drawing.Color.Red;
            this.lblErreurs.Location = new System.Drawing.Point(12, 9);
            this.lblErreurs.Name = "lblErreurs";
            this.lblErreurs.Size = new System.Drawing.Size(603, 67);
            this.lblErreurs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intitule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Objectif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date début";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type public";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Agence communication";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Agence artistique";
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(291, 107);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(179, 20);
            this.txtIntitule.TabIndex = 9;
            // 
            // txtObjectif
            // 
            this.txtObjectif.Location = new System.Drawing.Point(291, 151);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(179, 20);
            this.txtObjectif.TabIndex = 11;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(291, 189);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 13;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(291, 232);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 14;
            // 
            // cboAgenceCommu
            // 
            this.cboAgenceCommu.FormattingEnabled = true;
            this.cboAgenceCommu.Location = new System.Drawing.Point(291, 363);
            this.cboAgenceCommu.Name = "cboAgenceCommu";
            this.cboAgenceCommu.Size = new System.Drawing.Size(200, 21);
            this.cboAgenceCommu.TabIndex = 15;
            // 
            // cboAgenceArtistique
            // 
            this.cboAgenceArtistique.FormattingEnabled = true;
            this.cboAgenceArtistique.Location = new System.Drawing.Point(291, 402);
            this.cboAgenceArtistique.Name = "cboAgenceArtistique";
            this.cboAgenceArtistique.Size = new System.Drawing.Size(200, 21);
            this.cboAgenceArtistique.TabIndex = 16;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(168, 480);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(80, 25);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(346, 480);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(80, 23);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cboTypePublic
            // 
            this.cboTypePublic.FormattingEnabled = true;
            this.cboTypePublic.Location = new System.Drawing.Point(291, 278);
            this.cboTypePublic.Name = "cboTypePublic";
            this.cboTypePublic.Size = new System.Drawing.Size(200, 21);
            this.cboTypePublic.TabIndex = 19;
            // 
            // cboEmploye
            // 
            this.cboEmploye.FormattingEnabled = true;
            this.cboEmploye.Location = new System.Drawing.Point(291, 316);
            this.cboEmploye.Name = "cboEmploye";
            this.cboEmploye.Size = new System.Drawing.Size(200, 21);
            this.cboEmploye.TabIndex = 20;
            // 
            // FrmAjoutCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 539);
            this.Controls.Add(this.cboEmploye);
            this.Controls.Add(this.cboTypePublic);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cboAgenceArtistique);
            this.Controls.Add(this.cboAgenceCommu);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.txtObjectif);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErreurs);
            this.Name = "FrmAjoutCampagne";
            this.Text = "Ajouter une campagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtObjectif;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.ComboBox cboAgenceCommu;
        private System.Windows.Forms.ComboBox cboAgenceArtistique;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cboTypePublic;
        private System.Windows.Forms.ComboBox cboEmploye;
    }
}

