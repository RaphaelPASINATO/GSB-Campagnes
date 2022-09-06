using Campagnes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campagnes.GUI
{
    public partial class FrmAjouterArtiste : Form
    {
        private CourantArtistiqueManager courantArtistiqueManager = new CourantArtistiqueManager();
        private ArtisteManager artisteManager = new ArtisteManager();
        public FrmAjouterArtiste()
        {
            InitializeComponent();

            lblErreurs.Text = "";

            #region Remplir la liste des catégories
            cboCourantArt.DataSource = courantArtistiqueManager.GetLesCourantArtistique();
            cboCourantArt.DisplayMember = "Libelle";
            cboCourantArt.ValueMember = "Id";
            cboCourantArt.SelectedIndex = -1;
            #endregion
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            lblErreurs.Text = "";
            List<string> erreurs = artisteManager.GetLesErreurs(txtNom.Text, txtSiteWeb.Text, cboCourantArt.SelectedIndex);
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
            string nom = txtNom.Text;
            string siteWeb = txtSiteWeb.Text;
            int idCourantArtistique = Convert.ToInt32(cboCourantArt.SelectedValue.ToString());
            int ret = artisteManager.AjouterArtiste(nom, siteWeb, idCourantArtistique);
            if (ret == 0)
            {
                MessageBox.Show("Artiste ajouté", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'artiste n’a pas été ajouté",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            this.Close();
        }
    }
}
