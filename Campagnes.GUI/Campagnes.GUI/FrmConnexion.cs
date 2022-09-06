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
    public partial class FrmConnexion : Form
    {
        public Utilisateur User;
        public List<Fonctionnalite> LesAutorisations;
        private UtilisateurManager utilisateurManager = new UtilisateurManager();
        public FrmConnexion()
        {
            InitializeComponent();
            lblErreurs.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            User = utilisateurManager.InfosUtilisateur(txtLogin.Text, txtMdp.Text);
            if (User == null)
            {
                lblErreurs.Text = "Vos informations de connexion sont erronées";
                return;
            }

            lblErreurs.Text = "";
            LesAutorisations = utilisateurManager.GetLesFonctionnalitesAutorisees(txtLogin.Text);
            this.Close();
        }
    }
}
