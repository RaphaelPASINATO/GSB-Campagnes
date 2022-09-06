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
    public partial class FrmAjoutEvenement : Form
    {
        private EvenementManager evenementManager = new EvenementManager();
        private VilleManager villeManager = new VilleManager();
        private CampagneManager campagneManager = new CampagneManager();
        public FrmAjoutEvenement()
        {
            InitializeComponent();

            lblErreurs.Visible = false;

            #region Remplir la liste des catégories
            cboVille.DataSource = villeManager.GetLesVilles();
            cboVille.DisplayMember = "nomVille";
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

        private void bntAjout_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
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
            string Intitule = txtIntitule.Text;
            DateTime DateDebut = dtpDateDebut.Value;
            DateTime DateFin = dtpDateFin.Value;
            int IdCampagne = Convert.ToInt32(cboCampagne.SelectedValue);
            string CodeInseeVille = Convert.ToString(cboVille.SelectedValue);
            int ret = evenementManager.AjouterEvenement(Intitule, DateDebut, DateFin, IdCampagne, CodeInseeVille);
            if (ret == 0)
            {
                MessageBox.Show("Evenement ajouté", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                // Vider le formulaire
                txtIntitule.Clear();
                dtpDateDebut.Value = DateTime.Now;
                dtpDateFin.Value = DateTime.Now;
                cboCampagne.SelectedIndex = -1;
                cboVille.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Un problème est survenu, l'evenement n’a pas été ajouté",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
