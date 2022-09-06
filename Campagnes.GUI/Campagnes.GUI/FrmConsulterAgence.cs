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
    public partial class FrmConsulterAgence : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        public FrmConsulterAgence()
        {
            InitializeComponent();
            afficherToutesLesAgences();
        }

        

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBoxComm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxComm.Checked == true && chkBoxArt.Checked == false)
            {
                afficherLesAgencesCommunication();
                return;
            }
            if (chkBoxComm.Checked == false && chkBoxArt.Checked == true)
            {
                afficherLesAgencesArtistiques();
                return;
            }
            afficherToutesLesAgences();
        }

        private void chkBoxArt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxComm.Checked == true && chkBoxArt.Checked == false)
            {
                afficherLesAgencesCommunication();
                return;
            }
            if (chkBoxComm.Checked == false && chkBoxArt.Checked == true)
            {
                afficherLesAgencesArtistiques();
                return;
            }
            afficherToutesLesAgences();
        }

        private void afficherToutesLesAgences()
        {
            dgvConsulter.DataSource = agenceManager.GetLesAgences();
            miseEnFormeDgv();
        }

        private void afficherLesAgencesArtistiques()
        {
            dgvConsulter.DataSource = agenceManager.GetLesAgencesParSpecialite("Artistique");
            miseEnFormeDgv();
        }

        private void afficherLesAgencesCommunication()
        {
            dgvConsulter.DataSource = agenceManager.GetLesAgencesParSpecialite("Communication");
            miseEnFormeDgv();
        }

        private void miseEnFormeDgv()
        {
            #region Suppresion des colonnes
            dgvConsulter.Columns["Campagnes"].Visible = false;
            dgvConsulter.Columns["Campagnes1"].Visible = false;
            dgvConsulter.Columns["Id"].Visible = false;
            dgvConsulter.Columns["Ville"].Visible = false;
            dgvConsulter.Columns["CodeInseeVille"].Visible = false;
            dgvConsulter.RowHeadersVisible = false;
            #endregion
            #region Rename des colonnes
            dgvConsulter.Columns["nomVille"].HeaderText = "Ville";
            dgvConsulter.Columns["SpecialiteAgence"].HeaderText = "Specialite";
            dgvConsulter.Columns["SiteWeb"].HeaderText = "Site web";
            #endregion
            #region Agencement des colonnes
            dgvConsulter.Columns["Nom"].DisplayIndex = 0;
            dgvConsulter.Columns["Adresse"].DisplayIndex = 1;
            dgvConsulter.Columns["NomVille"].DisplayIndex = 2;
            dgvConsulter.Columns["Telephone"].DisplayIndex = 3;
            dgvConsulter.Columns["Email"].DisplayIndex = 4;
            dgvConsulter.Columns["SiteWeb"].DisplayIndex = 5;
            dgvConsulter.Columns["SpecialiteAgence"].DisplayIndex = 6;

            dgvConsulter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConsulter.Columns["Adresse"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            #endregion
        }
    }
}