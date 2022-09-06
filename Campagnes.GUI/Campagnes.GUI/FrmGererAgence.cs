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
    public partial class FrmGererAgence : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        private Ville ville = null;
        public FrmGererAgence()
        {
            InitializeComponent();
            remplirListeAgence();
        }

        private void remplirListeAgence()
        {
            cboAgence.DataSource = agenceManager.GetLesAgences();
            cboAgence.DisplayMember = "Nom";
            cboAgence.ValueMember = "Nom";
            cboAgence.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void cboAgence_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cboAgence.SelectedIndex != -1)
            {
                Agence agence = (Agence)cboAgence.SelectedItem;
                txtNom.Text = agence.Nom;
                txtAdresse.Text = agence.Adresse;

                #region Remplir la liste des villes
                cboVilles.DataSource = agenceManager.GetLesVilles();
                cboVilles.DisplayMember = "nomVille";
                cboVilles.ValueMember = "CodeInsee";
                Ville ville = (Ville)cboVilles.SelectedItem;
                cboVilles.SelectedValue = agence.CodeInseeVille;
                #endregion

                txtTelephone.Text = agence.Telephone;
                txtEmail.Text = agence.Email;
                txtSiteWeb.Text = agence.SiteWeb;
                ;
                if (agence.SpecialiteAgence == "Artistique     ")
                {
                    rbArtistique.Checked = true;
                }
                else
                {
                    rbCommunication.Checked = true;
                }
                panel1.Visible = true;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Agence agence = (Agence)cboAgence.SelectedItem;
            int ret = agenceManager.SupprimerAgence(agence);
            if (ret == 0)
            {
                MessageBox.Show("Agence supprimée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                remplirListeAgence();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'agence n'a pas été supprimée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            lblErreurs.Text = "";
            List<string> erreurs = agenceManager.GetLesErreurs(txtNom.Text, txtAdresse.Text, txtTelephone.Text, txtEmail.Text, txtSiteWeb.Text, cboVilles.SelectedIndex, rbArtistique.Checked, rbCommunication.Checked);
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
            Agence agence = (Agence)cboAgence.SelectedItem;
            agence.Nom = txtNom.Text;
            agence.Adresse = txtAdresse.Text;
            agence.Email = txtEmail.Text;
            agence.Telephone = txtTelephone.Text;
            agence.SiteWeb = txtSiteWeb.Text;
            ville = (Ville)cboVilles.SelectedItem;
            agence.CodeInseeVille = ville.CodeInsee;
            if (rbArtistique.Checked)
            {
                agence.SpecialiteAgence = rbArtistique.Text;
            }
            else
            {
                agence.SpecialiteAgence = rbCommunication.Text;
            }

            int ret = agenceManager.ModifierAgence(agence);
            if (ret == 0)
            {
                MessageBox.Show("Agence modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                remplirListeAgence();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'agence n'a pas été modifié", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
    }
}
