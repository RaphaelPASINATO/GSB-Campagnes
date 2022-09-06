
namespace Campagnes.GUI
{
    partial class FrmGererCampagne
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
            this.cboCampagne = new System.Windows.Forms.ComboBox();
            this.cboAgenceCommu = new System.Windows.Forms.ComboBox();
            this.cboAgenceArtistique = new System.Windows.Forms.ComboBox();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtObjectif = new System.Windows.Forms.TextBox();
            this.cboEmploye = new System.Windows.Forms.ComboBox();
            this.cboTypePublic = new System.Windows.Forms.ComboBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.btnSuppArt = new System.Windows.Forms.Button();
            this.btnSuppCommu = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCampagne
            // 
            this.cboCampagne.FormattingEnabled = true;
            this.cboCampagne.Location = new System.Drawing.Point(292, 19);
            this.cboCampagne.Name = "cboCampagne";
            this.cboCampagne.Size = new System.Drawing.Size(158, 21);
            this.cboCampagne.TabIndex = 0;
            this.cboCampagne.SelectionChangeCommitted += new System.EventHandler(this.cboCampagne_SelectionChangeCommitted);
            // 
            // cboAgenceCommu
            // 
            this.cboAgenceCommu.FormattingEnabled = true;
            this.cboAgenceCommu.Location = new System.Drawing.Point(228, 346);
            this.cboAgenceCommu.Name = "cboAgenceCommu";
            this.cboAgenceCommu.Size = new System.Drawing.Size(200, 21);
            this.cboAgenceCommu.TabIndex = 1;
            // 
            // cboAgenceArtistique
            // 
            this.cboAgenceArtistique.FormattingEnabled = true;
            this.cboAgenceArtistique.Location = new System.Drawing.Point(228, 405);
            this.cboAgenceArtistique.Name = "cboAgenceArtistique";
            this.cboAgenceArtistique.Size = new System.Drawing.Size(200, 21);
            this.cboAgenceArtistique.TabIndex = 2;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(228, 13);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(158, 20);
            this.txtIntitule.TabIndex = 3;
            // 
            // txtObjectif
            // 
            this.txtObjectif.Location = new System.Drawing.Point(228, 80);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(158, 20);
            this.txtObjectif.TabIndex = 4;
            // 
            // cboEmploye
            // 
            this.cboEmploye.FormattingEnabled = true;
            this.cboEmploye.Location = new System.Drawing.Point(228, 290);
            this.cboEmploye.Name = "cboEmploye";
            this.cboEmploye.Size = new System.Drawing.Size(200, 21);
            this.cboEmploye.TabIndex = 5;
            // 
            // cboTypePublic
            // 
            this.cboTypePublic.FormattingEnabled = true;
            this.cboTypePublic.Location = new System.Drawing.Point(228, 235);
            this.cboTypePublic.Name = "cboTypePublic";
            this.cboTypePublic.Size = new System.Drawing.Size(200, 21);
            this.cboTypePublic.TabIndex = 6;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(228, 135);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 7;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(228, 185);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 8;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnSuppArt);
            this.panel.Controls.Add(this.btnSuppCommu);
            this.panel.Controls.Add(this.btnSupprimer);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnModifier);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.dtpDateDebut);
            this.panel.Controls.Add(this.dtpDateFin);
            this.panel.Controls.Add(this.cboAgenceCommu);
            this.panel.Controls.Add(this.cboAgenceArtistique);
            this.panel.Controls.Add(this.cboTypePublic);
            this.panel.Controls.Add(this.txtIntitule);
            this.panel.Controls.Add(this.cboEmploye);
            this.panel.Controls.Add(this.txtObjectif);
            this.panel.Location = new System.Drawing.Point(60, 111);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(598, 530);
            this.panel.TabIndex = 9;
            // 
            // btnSuppArt
            // 
            this.btnSuppArt.Location = new System.Drawing.Point(450, 405);
            this.btnSuppArt.Name = "btnSuppArt";
            this.btnSuppArt.Size = new System.Drawing.Size(75, 23);
            this.btnSuppArt.TabIndex = 20;
            this.btnSuppArt.Text = "Supprimer";
            this.btnSuppArt.UseVisualStyleBackColor = true;
            this.btnSuppArt.Click += new System.EventHandler(this.btnSuppArt_Click);
            // 
            // btnSuppCommu
            // 
            this.btnSuppCommu.Location = new System.Drawing.Point(450, 346);
            this.btnSuppCommu.Name = "btnSuppCommu";
            this.btnSuppCommu.Size = new System.Drawing.Size(75, 23);
            this.btnSuppCommu.TabIndex = 19;
            this.btnSuppCommu.Text = "Supprimer";
            this.btnSuppCommu.UseVisualStyleBackColor = true;
            this.btnSuppCommu.Click += new System.EventHandler(this.btnSuppCommu_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(328, 468);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Intitule";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(160, 468);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Agence artistique";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Agence communication";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type public";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Objectif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Campagne";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(303, 662);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(-6, 43);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(722, 51);
            this.lblErreur.TabIndex = 15;
            // 
            // FrmGererCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 697);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cboCampagne);
            this.Controls.Add(this.label7);
            this.Name = "FrmGererCampagne";
            this.Text = "Gérer les campagnes";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCampagne;
        private System.Windows.Forms.ComboBox cboAgenceCommu;
        private System.Windows.Forms.ComboBox cboAgenceArtistique;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtObjectif;
        private System.Windows.Forms.ComboBox cboEmploye;
        private System.Windows.Forms.ComboBox cboTypePublic;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnSuppArt;
        private System.Windows.Forms.Button btnSuppCommu;
    }
}