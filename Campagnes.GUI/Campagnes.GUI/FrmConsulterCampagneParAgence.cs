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
    public partial class FrmConsulterCampagneParAgence : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        private CampagneManager campagneManager = new CampagneManager();
        private EmployeManager employeManager = new EmployeManager();
        private TypePublicManager typePublicManager = new TypePublicManager();

        public FrmConsulterCampagneParAgence()
        {
            InitializeComponent();
            #region Remplir la liste des produits
            cboAgence.DataSource = agenceManager.GetLesAgencesCamp();
            cboAgence.DisplayMember = "Nom";
            cboAgence.ValueMember = "Id";
            cboAgence.SelectedIndex = -1;
            #endregion
            dgvCampagne.Visible = false;
        }

    

        private void cboAgence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboAgence.SelectedIndex != -1)
            {
                dgvCampagne.Visible = true;
                int idAgence = Convert.ToInt32(cboAgence.SelectedValue.ToString());
                dgvCampagne.DataSource = campagneManager.GetLesCampagnesParAgences(idAgence);

                // Masquer les éléments non souhaités
                dgvCampagne.Columns["Id"].Visible = false;
                dgvCampagne.Columns["idEmploye"].Visible = false;
                dgvCampagne.Columns["idTypePublic"].Visible = false;
                dgvCampagne.Columns["IdAgenceCommunication"].Visible = false;
                dgvCampagne.Columns["IdAgenceArtistique"].Visible = false;
                dgvCampagne.Columns["Agence"].Visible = false;
                dgvCampagne.Columns["Agence1"].Visible = false;
                dgvCampagne.Columns["Evenements"].Visible = false;
                dgvCampagne.Columns["Employe"].Visible = false;
                dgvCampagne.Columns["typePublic"].Visible = false;
                dgvCampagne.Columns["CampagneDebutFin"].Visible = false;

                dgvCampagne.Columns["nomEmploye"].HeaderText = "Employe";
                dgvCampagne.Columns["libelleTypePublic"].HeaderText = "TypePublic";
                dgvCampagne.Columns["DateDebut"].HeaderText = "Date début";
                dgvCampagne.Columns["DateFin"].HeaderText = "Date fin";

                // Taille des cellules adaptée au contenu
                dgvCampagne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvCampagne.RowHeadersVisible = false; // Entêtes de ligne masquées
                dgvCampagne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCampagne.BorderStyle = BorderStyle.None;
            }
        }
    }
}
