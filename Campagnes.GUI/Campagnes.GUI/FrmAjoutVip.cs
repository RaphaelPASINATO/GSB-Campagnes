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
    public partial class FrmAjoutVip : Form
    {
        private VipManager vipManager = new VipManager();
        private CategorieVipManager categorievipManager = new CategorieVipManager();
        private VilleManager villeManager = new VilleManager();

        public FrmAjoutVip()
        {
            InitializeComponent();
            cboCategorie.DataSource = categorievipManager.GetLesCategories();
            cboCategorie.DisplayMember = "Libelle";
            cboCategorie.ValueMember = "Id";
            cboCategorie.SelectedIndex = -1;
            cboVille.DataSource = villeManager.GetLesVilles();
            cboVille.DisplayMember = "NomVille";
            cboVille.ValueMember = "CodeInsee";
            cboVille.SelectedIndex = -1;

        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            lblErreurs.Text = "";
            List<string> erreurs = vipManager.GetLesErreurs(txtNom.Text, txtAdresse.Text, txtMail.Text, cboCategorie.SelectedIndex, cboVille.SelectedIndex);
            if (erreurs.Count != 0)
            {
                foreach (string err in erreurs)
                {
                    lblErreurs.Text += err + "\n";
                }
                return;
            }
            int idCategorie = Convert.ToInt32(cboCategorie.SelectedValue.ToString());

            int ret = vipManager.AjouterVip(txtNom.Text, txtAdresse.Text, txtMail.Text, idCategorie, cboVille.SelectedValue.ToString());
            if (ret == 0)
            {
                MessageBox.Show("Vip ajouté", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un problème est survenu, le Vip n’a pas été ajouté",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
