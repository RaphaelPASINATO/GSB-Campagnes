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

namespace Campagnes.GUI
{
    public partial class FrmConsulterArtiste : Form
    {
        private CourantArtistiqueManager courantArtistiqueManager = new CourantArtistiqueManager();
        private ArtisteManager artisteManager = new ArtisteManager();
        public FrmConsulterArtiste()
        {
            InitializeComponent();

            #region Remplir la liste des catégories
            cboListeArtiste.DataSource = courantArtistiqueManager.GetLesCourantArtistique();
            cboListeArtiste.DisplayMember = "Libelle";
            cboListeArtiste.ValueMember = "Id";
            cboListeArtiste.SelectedIndex = -1;
            #endregion

            dgvArtiste.Visible = false;
        }
 
        

        private void cboListeArtiste_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboListeArtiste.SelectedIndex != -1)
            {
                dgvArtiste.Visible = true;
                string test = cboListeArtiste.SelectedValue.ToString();
                int.TryParse(test, out int id);
                dgvArtiste.DataSource = artisteManager.GetLeArtistesParCourantArtistique(id);

                dgvArtiste.Columns["idCourantArtistique"].Visible = false;
                dgvArtiste.Columns["CourantArtistique"].Visible = false;
                dgvArtiste.Columns["Participations"].Visible = false;



                // Changer l’alignement du contenu des cellules
                dgvArtiste.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Gérer la largeur des colonnes (elles s’adaptent au contenu)
                // sauf pour la colonne Nom qui occupera la place restante
                dgvArtiste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvArtiste.BorderStyle = BorderStyle.None;

                dgvArtiste.RowHeadersVisible = false; // Entêtes de ligne masquées

            }
        }

        
    }
}
