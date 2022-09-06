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
    public partial class FrmConsultationEvenementsParCampagne : Form
    {
        private EvenementManager evenementManager = new EvenementManager();
        private VilleManager villeManager = new VilleManager();
        private CampagneManager campagneManager = new CampagneManager();
        public FrmConsultationEvenementsParCampagne()
        {
            InitializeComponent();
            #region Remplir la liste des catégories
            cboCampagne.DataSource = campagneManager.GetLesCampagnes();
            cboCampagne.DisplayMember = "CampagneDebutFin";
            cboCampagne.ValueMember = "Id";
            cboCampagne.SelectedIndex = -1;
            #endregion
            dvgEvenement.Visible = false;
        }

        private void cboCampagne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dvgEvenement.Visible = true;
            string test = cboCampagne.SelectedValue.ToString();
            dvgEvenement.DataSource = evenementManager.GetLesEvenementParCampagne(Convert.ToInt32(cboCampagne.SelectedValue.ToString()));

            // Masquer les éléments non souhaités
            dvgEvenement.Columns["Id"].Visible = false;
            dvgEvenement.Columns["Campagne"].Visible = false;
            dvgEvenement.Columns["Ville"].Visible = false;
            dvgEvenement.Columns["Messages"].Visible = false;
            dvgEvenement.Columns["Participations"].Visible = false;
            dvgEvenement.Columns["Vips"].Visible = false;
            dvgEvenement.Columns["IdCampagne"].Visible = false;
            dvgEvenement.Columns["CodeInseeVille"].Visible = false;
            // Changer l’alignement du contenu des cellules
            dvgEvenement.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Gérer la largeur des colonnes (elles s’adaptent au contenu)
            // sauf pour la colonne Nom qui occupera la place restante
            dvgEvenement.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Améliorer le rendu du datagridview (peut être fait en mode Design)
            dvgEvenement.RowHeadersVisible = false; // Entêtes de ligne masquées
            dvgEvenement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgEvenement.BorderStyle = BorderStyle.None;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
