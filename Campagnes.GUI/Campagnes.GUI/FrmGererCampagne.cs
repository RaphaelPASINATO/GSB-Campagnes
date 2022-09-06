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
    public partial class FrmGererCampagne : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        private CampagneManager campagneManager = new CampagneManager();
        private EmployeManager employeManager = new EmployeManager();
        private TypePublicManager typePublicManager = new TypePublicManager();

        private void remplirListeCampagne()
        {
            #region Remplir la liste des produits
            cboCampagne.DataSource = campagneManager.GetLesCampagnes();
            cboCampagne.DisplayMember = "intitule";
            cboCampagne.ValueMember = "Id";
            cboCampagne.SelectedIndex = -1;
            #endregion
        }
        public FrmGererCampagne()
        {
            InitializeComponent();
            #region Remplir la liste des produits
            remplirListeCampagne();
            #endregion

            #region Remplir la liste des campagne de communication
            cboAgenceCommu.DataSource = agenceManager.GetLesAgencesCommunications();
            cboAgenceCommu.DisplayMember = "Nom";
            cboAgenceCommu.ValueMember = "Id";
            cboAgenceCommu.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des campagne artistique
            cboAgenceArtistique.DataSource = agenceManager.GetLesAgencesArtistiques();
            cboAgenceArtistique.DisplayMember = "Nom";
            cboAgenceArtistique.ValueMember = "Id";
            cboAgenceArtistique.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des employes
            cboEmploye.DataSource = employeManager.GetLesEmployes();
            cboEmploye.DisplayMember = "Nom";
            cboEmploye.ValueMember = "Id";
            cboEmploye.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des types publics
            cboTypePublic.DataSource = typePublicManager.GetTypePublics();
            cboTypePublic.DisplayMember = "Libelle";
            cboTypePublic.ValueMember = "Id";
            cboTypePublic.SelectedIndex = -1;
            #endregion
            panel.Visible = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboCampagne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCampagne.SelectedIndex != -1)
            {
                Campagne laCampagne = (Campagne)cboCampagne.SelectedItem;
                txtIntitule.Text = laCampagne.Intitule;
                txtObjectif.Text = laCampagne.Objectif;
                dtpDateDebut.Value = laCampagne.DateDebut;
                dtpDateFin.Value = laCampagne.DateFin;
                cboTypePublic.SelectedValue = laCampagne.IdTypePublic;
                cboEmploye.SelectedValue = laCampagne.IdEmploye;
                if (laCampagne.IdAgenceCommunication == null)
                {
                    cboAgenceCommu.SelectedIndex = -1;
                }
                else
                {
                    cboAgenceCommu.SelectedValue = laCampagne.IdAgenceCommunication;
                }
                if (laCampagne.IdAgenceArtistique == null)
                {
                    cboAgenceArtistique.SelectedIndex = -1;
                }
                else
                {
                    cboAgenceArtistique.SelectedValue = laCampagne.IdAgenceArtistique;
                }

            }
            panel.Visible = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            List<string> erreurs = campagneManager.GetLesErreurs(txtIntitule.Text,
            txtObjectif.Text, dtpDateDebut.Value, dtpDateFin.Value, cboTypePublic.SelectedIndex, cboAgenceCommu.SelectedIndex, cboAgenceArtistique.SelectedIndex, cboEmploye.SelectedIndex);
            if (erreurs.Count != 0)
            {
                foreach (string err in erreurs)
                {
                    lblErreur.Text += err + "\n";
                }
                return;
            }



            #region Enregistrement de la campagne dans la BDD
            Campagne laCampagne = (Campagne)cboCampagne.SelectedItem;

            laCampagne.Intitule = txtIntitule.Text;
            laCampagne.Objectif = txtObjectif.Text;
            laCampagne.DateDebut = dtpDateDebut.Value;
            laCampagne.DateFin = dtpDateFin.Value;
            laCampagne.IdTypePublic = Convert.ToInt32(cboTypePublic.SelectedValue.ToString());
            laCampagne.IdEmploye = Convert.ToInt32(cboEmploye.SelectedValue.ToString());

            Nullable<int> idAgenceCommu = null;
            if (cboAgenceCommu.SelectedValue != null && cboAgenceCommu.SelectedIndex != -1)
            {
                idAgenceCommu = Convert.ToInt32(cboAgenceCommu.SelectedValue.ToString());
            }

            Nullable<int> idAgenceArtistique = null;
            if (cboAgenceArtistique.SelectedValue != null && cboAgenceArtistique.SelectedIndex != -1)
            {
                idAgenceArtistique = Convert.ToInt32(cboAgenceArtistique.SelectedValue.ToString());
            }

            laCampagne.IdAgenceCommunication = idAgenceCommu;
            laCampagne.IdAgenceArtistique = idAgenceArtistique;

            int ret = campagneManager.ModifierCampagne(laCampagne);
            if (ret == 0)
            {
                MessageBox.Show("Campagne modifié", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Un problème est survenu, la Campagne n’a pas été modifié",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            remplirListeCampagne();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            #region Supprimer une campagne de la liste
            Campagne laCampagne = (Campagne)cboCampagne.SelectedItem;
            laCampagne.Intitule = txtIntitule.Text;
            int ret = campagneManager.SupprimerCampagne(laCampagne);
            if (ret == 0)
            {
                MessageBox.Show("Produit supprimé", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le produit n’a pas été supprimé",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            remplirListeCampagne();
        }

        private void btnSuppCommu_Click(object sender, EventArgs e)
        {
            cboAgenceCommu.SelectedIndex = -1;
        }

        private void btnSuppArt_Click(object sender, EventArgs e)
        {
            cboAgenceArtistique.SelectedIndex = -1;
        }
    }
}
