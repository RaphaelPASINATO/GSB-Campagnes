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
    public partial class FrmAjouterAgence : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        private Ville ville = null;
        public FrmAjouterAgence()
        {
            InitializeComponent();
            #region Remplir la liste des villes
            cboVille.DataSource = agenceManager.GetLesVilles();
            cboVille.DisplayMember = "nomVille";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;
            #endregion
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            lblErreurs.Text = "";
            List<string> erreurs = agenceManager.GetLesErreurs(txtNom.Text, txtAdresse.Text, txtTel.Text, txtEmail.Text, txtSite.Text, cboVille.SelectedIndex,rbArtistique.Checked, rbCommunication.Checked);
            if (erreurs.Count != 0)
            {
                foreach (string err in erreurs)
                {
                    lblErreurs.Text += err + "\n";
                }
                return;
            }
            #endregion




            #region Enregistrement de l'agence dans la BDD
            string nom = txtNom.Text;
            string adresse = txtAdresse.Text;
            string telephone = txtTel.Text;
            string email = txtEmail.Text;
            string siteWeb = txtSite.Text;
            ville = (Ville)cboVille.SelectedItem;
            string codeInseeVille = ville.CodeInsee;
            string specialiteAgence = "";
            if (rbArtistique.Checked)
            {
                specialiteAgence = rbArtistique.Text;
            }
            else
            {
                specialiteAgence = rbCommunication.Text;
            }
            

            int ret = agenceManager.AjouterAgence(nom, adresse, telephone, email, siteWeb, codeInseeVille, specialiteAgence);
            if (ret == 0)
            {
                MessageBox.Show("Agence ajoutée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'agence n'a pas été ajoutée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            this.Close();
        }
    }
}
