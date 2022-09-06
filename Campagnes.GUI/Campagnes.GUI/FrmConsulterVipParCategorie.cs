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
    public partial class FrmConsulterVipParCategorie : Form
    {
        private VipManager vipManager = new VipManager();
        private CategorieVipManager categorievipManager = new CategorieVipManager();


        public FrmConsulterVipParCategorie()
        {
            InitializeComponent();
            cboCategories.DataSource = categorievipManager.GetLesCategories();
            cboCategories.DisplayMember = "Libelle";
            cboCategories.ValueMember = "Id";
            cboCategories.SelectedIndex = -1;
            dgvCategories.Visible = false;
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategories.SelectedIndex != -1)
            {
                dgvCategories.Visible = true;
                string test = cboCategories.SelectedValue.ToString();
                int.TryParse(test, out int id);
                dgvCategories.DataSource = vipManager.GetLesVipParCategorie(id);
                dgvCategories.Columns["Id"].Visible = false;
                dgvCategories.Columns["Ville"].Visible = false;
                dgvCategories.Columns["CategorieVip"].Visible = false;
                dgvCategories.Columns["Evenements"].Visible = false;
                dgvCategories.Columns["idCategorieVip"].Visible = false;
                dgvCategories.Columns["codeInseeVille"].Visible = false;
                dgvCategories.Columns["nomVille"].HeaderText = "Ville";
                dgvCategories.Columns["libelleCategorie"].HeaderText = "Categorie";


                dgvCategories.Columns["Ville"].DefaultCellStyle.Alignment =
                 DataGridViewContentAlignment.MiddleCenter;
                dgvCategories.Columns["Nom"].DefaultCellStyle.Alignment =
                 DataGridViewContentAlignment.MiddleCenter;
                dgvCategories.Columns["Adresse"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvCategories.Columns["Adresse"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
                dgvCategories.Columns["Mail"].DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
                dgvCategories.RowHeadersVisible = false; // Entêtes de ligne masquées
                dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategories.BackgroundColor = Color.White; // Couleur de fond






            }
        }
    }
}
