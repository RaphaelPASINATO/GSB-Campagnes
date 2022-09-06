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
    public partial class FrmGererVip : Form
    {
        private VipManager vipManager = new VipManager();
        private CategorieVipManager categorievipManager = new CategorieVipManager();
        private VilleManager villeManager = new VilleManager();
        public FrmGererVip()
        {
            InitializeComponent();
            remplirListeProduits();


        }

        private void cboVip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVip.SelectedIndex != -1)
            {
                panel1.Visible = true;
                Vip leVip = (Vip)cboVip.SelectedItem;
                txtNom.Text = leVip.Nom;
                txtMail.Text = leVip.Mail;
                txtAdresse.Text = leVip.Adresse;
                cboCategorie.SelectedValue = leVip.IdCategorieVip;
                cboVille.SelectedValue = leVip.CodeInseeVille;
            }
               
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Vip leVip = (Vip)cboVip.SelectedItem;
            int ret = vipManager.SupprimerVip(leVip);

            if (ret == 0)
            {
                remplirListeProduits();
                MessageBox.Show("Vip supprimé", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le Vip n’a pas été supprimé",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remplirListeProduits()
        {
            cboVip.DataSource = vipManager.GetLesVip();
            cboVip.DisplayMember = "Nom";
            cboVip.ValueMember = "Id";
            cboVip.SelectedIndex = -1;
            txtAdresse.Text = "";
            txtMail.Text = "";
            txtNom.Text = "";
            panel1.Visible = false;

            cboCategorie.DataSource = categorievipManager.GetLesCategories();
            cboCategorie.DisplayMember = "Libelle";
            cboCategorie.ValueMember = "Id";
            cboCategorie.SelectedIndex = -1;
            cboVille.DataSource = villeManager.GetLesVilles();
            cboVille.DisplayMember = "NomVille";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;



            //cboProduits.DataSource = produitManager.GetLesProduits();
            //cboProduits.DisplayMember = "nom";
            //cboProduits.ValueMember = "Id";
            //cboProduits.SelectedIndex = -1;
            //txtNom.Text = "";
            //txtPrixVente.Text = "";
            //cboCategories.DataSource = categorieManager.GetLesCategories();
            //cboCategories.DisplayMember = "Libelle";
            //cboCategories.ValueMember = "Id";
            //cboCategories.SelectedIndex = -1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            lblErreurs.Text = "";
            List<string> erreurs = vipManager.GetLesErreurs(txtNom.Text, txtAdresse.Text, txtMail.Text, cboCategorie.SelectedIndex, cboVille.SelectedIndex) ;
            if (erreurs.Count() > 0)
            {
                foreach (string uneErreur in erreurs)
                {
                    lblErreurs.Text += uneErreur + "\n";
                }
                return;
            }
            Vip leVip = (Vip)cboVip.SelectedItem;
            leVip.Nom = txtNom.Text;
            leVip.Adresse = txtAdresse.Text;
            leVip.Mail = txtMail.Text;
            int idCategorie = Convert.ToInt32(cboCategorie.SelectedValue.ToString());
            leVip.IdCategorieVip = idCategorie;
            leVip.CodeInseeVille = cboVille.SelectedValue.ToString();

            int ret = vipManager.ModifierVip(leVip);
            if (ret == 0)
            {
                remplirListeProduits();
                MessageBox.Show("Vip modifié", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le Vip n’a pas été modifié",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
