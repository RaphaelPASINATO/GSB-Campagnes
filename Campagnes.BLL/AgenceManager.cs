using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using Campagnes.DAL;
using System.Data;

namespace Campagnes.BLL
{
    public class AgenceManager
    {
        private AgenceDAO dal = new AgenceDAO();

        public List<Agence> GetLesAgencesCommunications()
        {
            return dal.GetLesAgencesCommunications();
        }

        public List<Agence> GetLesAgencesArtistiques()
        {
            return dal.GetLesAgencesArtistiques();
        }

        public List<Agence> GetLesAgencesCamp()
        {
            return dal.GetLesAgencesCamp();
        }

        public List<Agence> GetLesAgences()
        {
            return dal.GetLesAgences();
        }
        public List<Ville> GetLesVilles()
        {
            return dal.GetLesVilles();
        }
        public List<Agence> GetLesAgencesParSpecialite(string SpecialiteAgence)
        {
            return dal.GetLesAgencesParSpecialite(SpecialiteAgence);
        }

        public int SupprimerAgence(Agence agence)
        {
            return dal.SupprimerAgence(agence);
        }
        public DataTable GetNombreAgenceParVille()
        {
            return dal.GetNombreAgenceParVille();
        }

        public int ModifierAgence(Agence agence)
        {
            return dal.ModifierAgence(agence);
        }

        public int AjouterAgence(string nom, string adresse, string telephone, string email, string siteWeb, string codeInseeVille, string specialiteAgence)
        {
            Agence a = new Agence();
            a.Nom = nom;
            a.Adresse = adresse;
            a.Telephone = telephone;
            a.Email = email;
            a.SiteWeb = siteWeb;
            a.CodeInseeVille = codeInseeVille;
            a.SpecialiteAgence = specialiteAgence;
            return dal.AjouterAgence(a);
        }
        public List<string> GetLesErreurs(string nom, string adresse, string telephone, string email, string siteWeb, int selectedIndexVille, bool rbArtistique, bool rbCommunication)
        {
            List<string> lesErreurs = new List<string>();

            if (!ValidationDonnees.EstChampRempli(nom))
                lesErreurs.Add("Le nom de l'agence doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(adresse))
                lesErreurs.Add("Le prix de vente doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(telephone))
                lesErreurs.Add("Le telephone doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(email))
                lesErreurs.Add("L'email doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(siteWeb))
                lesErreurs.Add("Le site web doit être renseigné");
            if (!ValidationDonnees.EstLigneComboSelectionnee(selectedIndexVille))
                lesErreurs.Add("La Ville doit être renseignée");
            if (rbArtistique == false && rbCommunication == false)
                lesErreurs.Add("Une spécialité doit être séléctionnée");
            return lesErreurs;
        }
    }
}
