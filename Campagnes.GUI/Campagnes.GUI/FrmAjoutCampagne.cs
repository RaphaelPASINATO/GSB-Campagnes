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
    public partial class FrmAjoutCampagne : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        private CampagneManager campagneManager = new CampagneManager();
        private EmployeManager employeManager = new EmployeManager();
        private TypePublicManager typePublicManager = new TypePublicManager();



        public FrmAjoutCampagne()
        {
            InitializeComponent();

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

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            lblErreurs.Text = "";
            List<string> erreurs = campagneManager.GetLesErreurs(txtIntitule.Text,
            txtObjectif.Text, dtpDateDebut.Value, dtpDateFin.Value, cboTypePublic.SelectedIndex, cboAgenceCommu.SelectedIndex, cboAgenceArtistique.SelectedIndex, cboEmploye.SelectedIndex);
            if (erreurs.Count != 0)
            {
                foreach (string err in erreurs)
                {
                    lblErreurs.Text += err + "\n";
                }
                return;
            }
            #endregion
            #region Enregistrement de la campagne dans la BDD
            string intitule = txtIntitule.Text;
            string objectif = txtObjectif.Text;
            DateTime dateDebut  = dtpDateDebut.Value;
            DateTime dateFin = dtpDateFin.Value;
            int idTypePublic = Convert.ToInt32(cboTypePublic.SelectedValue.ToString());
            int idEmploye = Convert.ToInt32(cboEmploye.SelectedValue.ToString());

            Nullable<int> idAgenceCommu = null;
            if (cboAgenceCommu.SelectedValue != null)
            {
                idAgenceCommu = Convert.ToInt32(cboAgenceCommu.SelectedValue.ToString());
            }

            Nullable<int> idAgenceArtistique = null;
            if (cboAgenceArtistique.SelectedValue != null)
            {
                idAgenceArtistique = Convert.ToInt32(cboAgenceArtistique.SelectedValue.ToString());
            }
            
            int ret = campagneManager.AjouterCampagne(intitule, objectif, dateDebut, dateFin, idTypePublic, idAgenceCommu, idAgenceArtistique, idEmploye);

            string nom = txtIntitule.Text;

            if (ret == 0)
            {
                MessageBox.Show("Campagne ajouté", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, la campagne n’a pas été ajouté",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            this.Close();
        }
    }
}
