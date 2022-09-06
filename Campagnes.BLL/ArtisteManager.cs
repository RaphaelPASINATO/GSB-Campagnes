using Campagnes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.DAL;
using System.Data;

namespace Campagnes.BLL
{
    public class ArtisteManager
    {
      
        private ArtisteDAO dal = new ArtisteDAO();
        public List<Artiste> GetLesProduits()
        {
            return dal.GetLesArtistes();
        }
        public int AjouterArtiste(string nom, string siteWeb, int idCourantArtistique)
        {
            Artiste a = new Artiste();
            a.Nom = nom;
            a.SiteWeb = siteWeb;
            a.IdCourantArtistique = idCourantArtistique;
            return dal.AjouterArtiste(a);
        }

        public List<string> GetLesErreurs(string nom, string siteWeb, int selectIndexCourantArtistique)
        {
            List<string> lesErreurs = new List<string>();
            if (!ValidationDonnees.EstChampRempli(nom))
                lesErreurs.Add("Le nom de l'artiste doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(siteWeb))
                lesErreurs.Add("Le site web doit être renseign");
            if (!ValidationDonnees.EstLigneComboSelectionnee(selectIndexCourantArtistique))
                lesErreurs.Add("Le courant artistique doit être renseignée");
            return lesErreurs;
        }

        public List<Artiste> GetLeArtistesParCourantArtistique(int idCourantArtistique)
        {
            return dal.GetLeArtistesParCourantArtistique(idCourantArtistique);
        }

        public int ModifierArtiste(Artiste a)
        {

            return dal.ModifierArtiste(a);

        }
        public int SupprimerArtiste(Artiste a)
        {

            return dal.SupprimerArtiste(a);
        }
    }
}
