
namespace Campagnes.GUI
{
    partial class FrmAccueil
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.campagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterCampagne = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGererCampagnes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterListeCampagneParAgence = new System.Windows.Forms.ToolStripMenuItem();
            this.vIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterVip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGererVip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterListeVip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImporterCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.artisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterArtiste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGererArtiste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterListeArtiste = new System.Windows.Forms.ToolStripMenuItem();
            this.v = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterAgence = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGererAgence = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterListeAgence = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterAgenceParVille = new System.Windows.Forms.ToolStripMenuItem();
            this.evénementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterEvenement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGererEvenements = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulterListeEvenementParCampagne = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campagneToolStripMenuItem,
            this.vIPToolStripMenuItem,
            this.artisteToolStripMenuItem,
            this.v,
            this.evénementToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(787, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // campagneToolStripMenuItem
            // 
            this.campagneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterCampagne,
            this.btnGererCampagnes,
            this.btnConsulterListeCampagneParAgence});
            this.campagneToolStripMenuItem.Name = "campagneToolStripMenuItem";
            this.campagneToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.campagneToolStripMenuItem.Text = "Campagne";
            // 
            // btnAjouterCampagne
            // 
            this.btnAjouterCampagne.Name = "btnAjouterCampagne";
            this.btnAjouterCampagne.Size = new System.Drawing.Size(244, 22);
            this.btnAjouterCampagne.Text = "Ajouter une campagne";
            this.btnAjouterCampagne.Click += new System.EventHandler(this.btnAjouterCampagne_Click);
            // 
            // btnGererCampagnes
            // 
            this.btnGererCampagnes.Name = "btnGererCampagnes";
            this.btnGererCampagnes.Size = new System.Drawing.Size(244, 22);
            this.btnGererCampagnes.Text = "Gérer les campagnes";
            this.btnGererCampagnes.Click += new System.EventHandler(this.btnGererCampagnes_Click);
            // 
            // btnConsulterListeCampagneParAgence
            // 
            this.btnConsulterListeCampagneParAgence.Name = "btnConsulterListeCampagneParAgence";
            this.btnConsulterListeCampagneParAgence.Size = new System.Drawing.Size(244, 22);
            this.btnConsulterListeCampagneParAgence.Text = "Liste des campagnes par agence";
            this.btnConsulterListeCampagneParAgence.Click += new System.EventHandler(this.btnConsulterListeCampagneParAgence_Click);
            // 
            // vIPToolStripMenuItem
            // 
            this.vIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterVip,
            this.btnGererVip,
            this.btnConsulterListeVip,
            this.btnImporterCsv});
            this.vIPToolStripMenuItem.Name = "vIPToolStripMenuItem";
            this.vIPToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.vIPToolStripMenuItem.Text = "VIP";
            // 
            // btnAjouterVip
            // 
            this.btnAjouterVip.Name = "btnAjouterVip";
            this.btnAjouterVip.Size = new System.Drawing.Size(180, 22);
            this.btnAjouterVip.Text = "Ajouter un VIP";
            this.btnAjouterVip.Click += new System.EventHandler(this.btnAjouterVip_Click);
            // 
            // btnGererVip
            // 
            this.btnGererVip.Name = "btnGererVip";
            this.btnGererVip.Size = new System.Drawing.Size(180, 22);
            this.btnGererVip.Text = "Gérer les VIP";
            this.btnGererVip.Click += new System.EventHandler(this.btnGererVip_Click);
            // 
            // btnConsulterListeVip
            // 
            this.btnConsulterListeVip.Name = "btnConsulterListeVip";
            this.btnConsulterListeVip.Size = new System.Drawing.Size(180, 22);
            this.btnConsulterListeVip.Text = "Consulter les VIP";
            this.btnConsulterListeVip.Click += new System.EventHandler(this.btnConsulterListeVip_Click);
            // 
            // btnImporterCsv
            // 
            this.btnImporterCsv.Name = "btnImporterCsv";
            this.btnImporterCsv.Size = new System.Drawing.Size(180, 22);
            this.btnImporterCsv.Text = "Importer les villes";
            this.btnImporterCsv.Click += new System.EventHandler(this.btnImporterCsv_Click);
            // 
            // artisteToolStripMenuItem
            // 
            this.artisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterArtiste,
            this.btnGererArtiste,
            this.btnConsulterListeArtiste});
            this.artisteToolStripMenuItem.Name = "artisteToolStripMenuItem";
            this.artisteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.artisteToolStripMenuItem.Text = "Artiste";
            // 
            // btnAjouterArtiste
            // 
            this.btnAjouterArtiste.CheckOnClick = true;
            this.btnAjouterArtiste.DoubleClickEnabled = true;
            this.btnAjouterArtiste.Name = "btnAjouterArtiste";
            this.btnAjouterArtiste.ShowShortcutKeys = false;
            this.btnAjouterArtiste.Size = new System.Drawing.Size(298, 22);
            this.btnAjouterArtiste.Text = "Ajouter un artiste";
            this.btnAjouterArtiste.Click += new System.EventHandler(this.ajoutArtiseToolStripMenuItem_Click);
            // 
            // btnGererArtiste
            // 
            this.btnGererArtiste.Name = "btnGererArtiste";
            this.btnGererArtiste.Size = new System.Drawing.Size(298, 22);
            this.btnGererArtiste.Text = "Gérer les artistes";
            this.btnGererArtiste.Click += new System.EventHandler(this.gérerArtisteToolStripMenuItem_Click);
            // 
            // btnConsulterListeArtiste
            // 
            this.btnConsulterListeArtiste.Name = "btnConsulterListeArtiste";
            this.btnConsulterListeArtiste.Size = new System.Drawing.Size(298, 22);
            this.btnConsulterListeArtiste.Text = "Consulter les artistes par courant artistique";
            this.btnConsulterListeArtiste.Click += new System.EventHandler(this.btnConsulterListeArtiste_Click);
            // 
            // v
            // 
            this.v.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterAgence,
            this.btnGererAgence,
            this.btnConsulterListeAgence,
            this.btnConsulterAgenceParVille});
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(59, 20);
            this.v.Text = "Agence";
            // 
            // btnAjouterAgence
            // 
            this.btnAjouterAgence.Name = "btnAjouterAgence";
            this.btnAjouterAgence.Size = new System.Drawing.Size(209, 22);
            this.btnAjouterAgence.Text = "Ajouter une agence";
            this.btnAjouterAgence.Click += new System.EventHandler(this.btnAjouterAgence_Click);
            // 
            // btnGererAgence
            // 
            this.btnGererAgence.Name = "btnGererAgence";
            this.btnGererAgence.Size = new System.Drawing.Size(209, 22);
            this.btnGererAgence.Text = "Gérer les agences";
            this.btnGererAgence.Click += new System.EventHandler(this.btnGererAgence_Click);
            // 
            // btnConsulterListeAgence
            // 
            this.btnConsulterListeAgence.Name = "btnConsulterListeAgence";
            this.btnConsulterListeAgence.Size = new System.Drawing.Size(209, 22);
            this.btnConsulterListeAgence.Text = "Consulter les agences";
            this.btnConsulterListeAgence.Click += new System.EventHandler(this.btnConsulterListeAgence_Click);
            // 
            // btnConsulterAgenceParVille
            // 
            this.btnConsulterAgenceParVille.Name = "btnConsulterAgenceParVille";
            this.btnConsulterAgenceParVille.Size = new System.Drawing.Size(209, 22);
            this.btnConsulterAgenceParVille.Text = "Liste des agences par ville";
            this.btnConsulterAgenceParVille.Click += new System.EventHandler(this.btnConsulterAgenceParVille_Click);
            // 
            // evénementToolStripMenuItem
            // 
            this.evénementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterEvenement,
            this.btnGererEvenements,
            this.btnConsulterListeEvenementParCampagne});
            this.evénementToolStripMenuItem.Name = "evénementToolStripMenuItem";
            this.evénementToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.evénementToolStripMenuItem.Text = "Evénement";
            // 
            // btnAjouterEvenement
            // 
            this.btnAjouterEvenement.Name = "btnAjouterEvenement";
            this.btnAjouterEvenement.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterEvenement.Text = "Ajouter un évènement";
            this.btnAjouterEvenement.Click += new System.EventHandler(this.btnAjouterEvenement_Click);
            // 
            // btnGererEvenements
            // 
            this.btnGererEvenements.Name = "btnGererEvenements";
            this.btnGererEvenements.Size = new System.Drawing.Size(278, 22);
            this.btnGererEvenements.Text = "Gérer les évènements";
            this.btnGererEvenements.Click += new System.EventHandler(this.btnGererEvenements_Click);
            // 
            // btnConsulterListeEvenementParCampagne
            // 
            this.btnConsulterListeEvenementParCampagne.Name = "btnConsulterListeEvenementParCampagne";
            this.btnConsulterListeEvenementParCampagne.Size = new System.Drawing.Size(278, 22);
            this.btnConsulterListeEvenementParCampagne.Text = "Liste des évènements d\'une campagne";
            this.btnConsulterListeEvenementParCampagne.Click += new System.EventHandler(this.btnConsulterListeEvenementParCampagne_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Campagnes de Sensibilisation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campagnes.GUI.Properties.Resources.photoFond;
            this.ClientSize = new System.Drawing.Size(787, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.Shown += new System.EventHandler(this.FrmAccueil1_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem campagneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterCampagne;
        private System.Windows.Forms.ToolStripMenuItem btnGererCampagnes;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterListeCampagneParAgence;
        private System.Windows.Forms.ToolStripMenuItem vIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterVip;
        private System.Windows.Forms.ToolStripMenuItem btnGererVip;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterListeVip;
        private System.Windows.Forms.ToolStripMenuItem btnImporterCsv;
        private System.Windows.Forms.ToolStripMenuItem artisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterArtiste;
        private System.Windows.Forms.ToolStripMenuItem btnGererArtiste;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterListeArtiste;
        private System.Windows.Forms.ToolStripMenuItem v;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterAgence;
        private System.Windows.Forms.ToolStripMenuItem btnGererAgence;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterListeAgence;
        private System.Windows.Forms.ToolStripMenuItem evénementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterEvenement;
        private System.Windows.Forms.ToolStripMenuItem btnGererEvenements;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterListeEvenementParCampagne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btnConsulterAgenceParVille;
    }
}