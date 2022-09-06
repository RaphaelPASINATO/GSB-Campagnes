using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campagnes.BLL;
using Campagnes.BO;

namespace Campagnes.GUI
{
    public partial class FrmGererArtiste : Form
    {
        private CourantArtistiqueManager courantArtistiqueManager = new CourantArtistiqueManager();
        private ArtisteManager artisteManager = new ArtisteManager();
        public FrmGererArtiste()
        {
            InitializeComponent();

            lblErreurs.Text = "";

            #region Remplir la liste des produits
            remplirListeArtiste();
            #endregion

            #region Remplir la liste des catégories
            cboCourantArtistique.DataSource = courantArtistiqueManager.GetLesCourantArtistique();
            cboCourantArtistique.DisplayMember = "Libelle";
            cboCourantArtistique.ValueMember = "Id";
            cboCourantArtistique.SelectedIndex = -1;
            #endregion
        }


        private void remplirListeArtiste()
        {
            cboArtiste.DataSource = artisteManager.GetLesProduits();
            cboArtiste.DisplayMember = "nom";
            cboArtiste.ValueMember = "Id";
            cboArtiste.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArtiste.SelectedIndex != -1)
            {
                Artiste unArtiste = (Artiste)cboArtiste.SelectedItem;
                txtNom.Text = unArtiste.Nom;
                txtSiteWeb.Text = unArtiste.SiteWeb;
                cboCourantArtistique.SelectedValue = unArtiste.IdCourantArtistique;
                panel1.Visible = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            lblErreurs.Text = "";
            List<string> erreurs = artisteManager.GetLesErreurs(txtNom.Text, txtSiteWeb.Text, cboCourantArtistique.SelectedIndex);
            if (erreurs.Count != 0)
            {
                foreach (string err in erreurs)
                {
                    lblErreurs.Text += err + "\n";
                }
                return;
            }
            #endregion

            #region Enregistrement du produit dans la BDD
            Artiste Artiste = (Artiste)cboArtiste.SelectedItem;
            Artiste.Nom = txtNom.Text;
            Artiste.SiteWeb = txtSiteWeb.Text;
            Artiste.IdCourantArtistique = Convert.ToInt32(cboCourantArtistique.SelectedValue.ToString());
            int ret = artisteManager.ModifierArtiste(Artiste);
            if (ret == 0)
            {
                MessageBox.Show("L'artiste modifié", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                remplirListeArtiste();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, L'artiste  n’a pas été modifié",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            #region Supprimer l'artiste dans la BDD
            Artiste Artiste = (Artiste)cboArtiste.SelectedItem;
            int ret = artisteManager.SupprimerArtiste(Artiste);
            if (ret == 0)
            {
                MessageBox.Show("Produit supprimé", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                remplirListeArtiste();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le produit n’a pas été supprimé",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
    }
}
