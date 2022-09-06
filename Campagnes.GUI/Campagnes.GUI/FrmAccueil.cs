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


namespace Campagnes.GUI
{
    public partial class FrmAccueil : Form
    {
        private Utilisateur utilisateurIdentifie = new Utilisateur();
        private List<Fonctionnalite> LesFonctionnalitesAutorisees = new List<Fonctionnalite>();
        private List<ToolStripMenuItem> lesMenus;
        public FrmAccueil()
        {
            InitializeComponent();
            lesMenus = getMenus();
            desactiveMenus();
            activeMenus();


        }

        private void desactiveMenus()
        {
            foreach (ToolStripMenuItem menu in lesMenus)
            {
                menu.Enabled = false;
            }
        }

        private void activeMenus()
        {
            foreach (ToolStripMenuItem menu in lesMenus)
            {
                if (LesFonctionnalitesAutorisees.Exists(f => f.identifiantMenu == menu.Name) == true)
                {
                    menu.Enabled = true;
                }
            }
        }
        private void FrmAccueil1_Shown(object sender, EventArgs e)
        {
            utilisateurIdentifie = null;
            using (FrmConnexion formLogin = new FrmConnexion())
            {
                // Affiche le formulaire de connexion qui va se charger de récupérer les
                // les informations de l’utilisteur authentifié ainsi que la liste de
                // toutes les fonctionnalités auxquelles il est habilité
                formLogin.ShowDialog();
                // La fenêtre modale d'identification est maintenant fermée. On récupère
                // les informations dans le formulaire courant
                utilisateurIdentifie = formLogin.User;
                LesFonctionnalitesAutorisees = formLogin.LesAutorisations;
                // On active les éléments de menu auxquels l’utilisateur est habilité
                if (LesFonctionnalitesAutorisees != null && utilisateurIdentifie != null)
                {
                    activeMenus();
                }
            }
        }

        private List<ToolStripMenuItem> getMenus()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem item in menu.Items)
            {
                allItems.AddRange(GetItems(item));
            }
            return allItems;
        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            if (item.HasDropDown == false)
            {
                yield return item;
            }
            else
            {
                foreach (ToolStripMenuItem dropDoownItem in item.DropDownItems)
                {
                    if (dropDoownItem.HasDropDown)
                    {
                        foreach (ToolStripMenuItem subItem in GetItems(dropDoownItem))
                            yield return subItem;
                    }
                    yield return dropDoownItem;
                }
            }
        }

        private void ajoutArtiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAjouterArtiste()).ShowDialog();
        }

        private void gérerArtisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmGererArtiste()).ShowDialog();
        }

        private void btnConsulterListeArtiste_Click(object sender, EventArgs e)
        {
            (new FrmConsulterArtiste()).ShowDialog();
        }

        private void btnAjouterVip_Click(object sender, EventArgs e)
        {
            (new FrmAjoutVip()).ShowDialog();
        }

        private void btnGererVip_Click(object sender, EventArgs e)
        {
            (new FrmGererVip()).ShowDialog();

        }

        private void btnConsulterListeVip_Click(object sender, EventArgs e)
        {
            (new FrmConsulterVipParCategorie()).ShowDialog();
        }

        private void btnImporterCsv_Click(object sender, EventArgs e)
        {
            (new FrmImporterVille()).ShowDialog();

        }

        private void btnAjouterCampagne_Click(object sender, EventArgs e)
        {
            (new FrmAjoutCampagne()).ShowDialog();
        }

        private void btnGererCampagnes_Click(object sender, EventArgs e)
        {
            (new FrmGererCampagne()).ShowDialog();
        }

        private void btnConsulterListeCampagneParAgence_Click(object sender, EventArgs e)
        {
            (new FrmConsulterCampagneParAgence()).ShowDialog();
        }

        private void btnAjouterAgence_Click(object sender, EventArgs e)
        {
            (new FrmAjouterAgence()).ShowDialog();

        }

        private void btnGererAgence_Click(object sender, EventArgs e)
        {
            (new FrmGererAgence()).ShowDialog();
        }

        private void btnConsulterListeAgence_Click(object sender, EventArgs e)
        {
            (new FrmConsulterAgence()).ShowDialog();
        }

       

        private void btnAjouterEvenement_Click(object sender, EventArgs e)
        {
            (new FrmAjoutEvenement()).ShowDialog();
        }

        private void btnGererEvenements_Click(object sender, EventArgs e)
        {
            (new FrmGererEvenement()).ShowDialog();
        }

        private void btnConsulterListeEvenementParCampagne_Click(object sender, EventArgs e)
        {
            (new FrmConsultationEvenementsParCampagne()).ShowDialog();
        }

        private void btnConsulterAgenceParVille_Click(object sender, EventArgs e)
        {
            (new FrmNbAgenceParVille()).ShowDialog();
        }
    }

}