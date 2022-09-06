using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campagnes.BO;
using Campagnes.BLL;

namespace Campagnes.GUI
{
    public partial class FrmGererEvenement : Form
    {
        private EvenementManager evenementManager = new EvenementManager();
        private VilleManager villeManager = new VilleManager();
        private CampagneManager campagneManager = new CampagneManager();
        public FrmGererEvenement()
        {
            InitializeComponent();
            panel1.Visible = false;
            lblErreurs.Visible = false;

            #region Remplir la liste des Produits
            remplirListeEvenement();
            #endregion

            #region Remplir la liste des catégories
            cboVille.DataSource = villeManager.GetLesVilles();
            cboVille.DisplayMember = "NomVille";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;
            #endregion


            #region Remplir la liste des catégories
            cboCampagne.DataSource = campagneManager.GetLesCampagnes();
            cboCampagne.DisplayMember = "CampagneDebutFin";
            cboCampagne.ValueMember = "Id";
            cboCampagne.SelectedIndex = -1;
            #endregion

        }

        private void cboEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEvenement.SelectedIndex != -1)
            {
                Evenement lEvenement = (Evenement)cboEvenement.SelectedItem;
                txtIntitule.Text = lEvenement.Intitule;
                dtpDateDebut.Value = lEvenement.DateDebut;
                dtpDateFin.Value = lEvenement.DateFin;
                cboCampagne.SelectedValue = lEvenement.IdCampagne;
                cboVille.SelectedValue = lEvenement.CodeInseeVille;
                panel1.Visible = true;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            Evenement lEvenement = (Evenement)cboEvenement.SelectedItem;
            lblErreurs.Text = "";
            List<string> erreurs = evenementManager.GetLesErreurs(txtIntitule.Text, dtpDateDebut.Value, dtpDateFin.Value, cboCampagne.SelectedIndex, cboVille.SelectedIndex);
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
            lEvenement.Intitule = txtIntitule.Text;
            lEvenement.DateDebut = dtpDateDebut.Value;
            lEvenement.DateFin = dtpDateFin.Value;
            lEvenement.IdCampagne = Convert.ToInt32(cboCampagne.SelectedValue);
            lEvenement.CodeInseeVille = Convert.ToString(cboVille.SelectedValue);


            int ret = evenementManager.ModifierEvenement(lEvenement);
            if (ret == 0)
            {
                MessageBox.Show("Evenement Modifié", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                remplirListeEvenement();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'evenement n’a pas été Modifié",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        private void remplirListeEvenement()
        {
            cboEvenement.DataSource = null;
            cboEvenement.DataSource = evenementManager.GetLesEvenement();
            cboEvenement.DisplayMember = "Intitule";
            cboEvenement.ValueMember = "Id";
            cboEvenement.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Evenement lEvenement = (Evenement)cboEvenement.SelectedItem;
            int ret = evenementManager.SupprimerEvenement(lEvenement);
            if (ret == 0)
            {
                MessageBox.Show("Produit supprimé", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                remplirListeEvenement();
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le produit n’a pas été supprimé",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
