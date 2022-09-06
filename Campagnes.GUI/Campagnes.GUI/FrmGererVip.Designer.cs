
namespace Campagnes.GUI
{
    partial class FrmGererVip
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
            this.cboVip = new System.Windows.Forms.ComboBox();
            this.lblVip = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cboVille = new System.Windows.Forms.ComboBox();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErreurs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVip
            // 
            this.cboVip.FormattingEnabled = true;
            this.cboVip.Location = new System.Drawing.Point(300, 12);
            this.cboVip.Name = "cboVip";
            this.cboVip.Size = new System.Drawing.Size(195, 21);
            this.cboVip.TabIndex = 0;
            this.cboVip.SelectedIndexChanged += new System.EventHandler(this.cboVip_SelectedIndexChanged);
            // 
            // lblVip
            // 
            this.lblVip.AutoSize = true;
            this.lblVip.Location = new System.Drawing.Point(229, 20);
            this.lblVip.Name = "lblVip";
            this.lblVip.Size = new System.Drawing.Size(22, 13);
            this.lblVip.TabIndex = 1;
            this.lblVip.Text = "Vip";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(168, 21);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(195, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(168, 105);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(168, 149);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(195, 20);
            this.txtAdresse.TabIndex = 4;
            // 
            // cboVille
            // 
            this.cboVille.FormattingEnabled = true;
            this.cboVille.Location = new System.Drawing.Point(168, 60);
            this.cboVille.Name = "cboVille";
            this.cboVille.Size = new System.Drawing.Size(195, 21);
            this.cboVille.TabIndex = 5;
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(168, 185);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(195, 21);
            this.cboCategorie.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(97, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(97, 68);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(97, 112);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(97, 156);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 10;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(97, 193);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 11;
            this.lblCategorie.Text = "Catégorie";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(149, 251);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(278, 251);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(341, 415);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 14;
            this.btnQuitter.Text = "Fermer";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.txtAdresse);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.cboVille);
            this.panel1.Controls.Add(this.lblCategorie);
            this.panel1.Controls.Add(this.cboCategorie);
            this.panel1.Controls.Add(this.lblAdresse);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblVille);
            this.panel1.Location = new System.Drawing.Point(132, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 306);
            this.panel1.TabIndex = 15;
            // 
            // lblErreurs
            // 
            this.lblErreurs.Location = new System.Drawing.Point(12, 40);
            this.lblErreurs.Name = "lblErreurs";
            this.lblErreurs.Size = new System.Drawing.Size(776, 48);
            this.lblErreurs.TabIndex = 16;
            // 
            // FrmGererVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreurs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblVip);
            this.Controls.Add(this.cboVip);
            this.Name = "FrmGererVip";
            this.Text = "Gérer les Vip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVip;
        private System.Windows.Forms.Label lblVip;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cboVille;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErreurs;
    }
}