
namespace Campagnes.GUI
{
    partial class FrmGererArtiste
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboArtiste = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.cboCourantArtistique = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErreurs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artsite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Artiste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site Web";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Courant Artistique";
            // 
            // cboArtiste
            // 
            this.cboArtiste.FormattingEnabled = true;
            this.cboArtiste.Location = new System.Drawing.Point(348, 30);
            this.cboArtiste.Name = "cboArtiste";
            this.cboArtiste.Size = new System.Drawing.Size(121, 21);
            this.cboArtiste.TabIndex = 4;
            this.cboArtiste.SelectedIndexChanged += new System.EventHandler(this.cboArtiste_SelectedIndexChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(248, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(248, 77);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(100, 20);
            this.txtSiteWeb.TabIndex = 6;
            // 
            // cboCourantArtistique
            // 
            this.cboCourantArtistique.FormattingEnabled = true;
            this.cboCourantArtistique.Location = new System.Drawing.Point(248, 135);
            this.cboCourantArtistique.Name = "cboCourantArtistique";
            this.cboCourantArtistique.Size = new System.Drawing.Size(121, 21);
            this.cboCourantArtistique.TabIndex = 7;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(136, 237);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(294, 237);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(348, 450);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.txtSiteWeb);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCourantArtistique);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(133, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 327);
            this.panel1.TabIndex = 11;
            // 
            // lblErreurs
            // 
            this.lblErreurs.AutoSize = true;
            this.lblErreurs.ForeColor = System.Drawing.Color.Red;
            this.lblErreurs.Location = new System.Drawing.Point(364, 536);
            this.lblErreurs.Name = "lblErreurs";
            this.lblErreurs.Size = new System.Drawing.Size(40, 13);
            this.lblErreurs.TabIndex = 12;
            this.lblErreurs.Text = "Erreurs";
            // 
            // FrmGererArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.lblErreurs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cboArtiste);
            this.Controls.Add(this.label1);
            this.Name = "FrmGererArtiste";
            this.Text = "Gérer les artistes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboArtiste;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.ComboBox cboCourantArtistique;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErreurs;
    }
}