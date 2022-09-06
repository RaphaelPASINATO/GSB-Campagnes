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
    public class EvenementManager
    {
        private EvenementDAO  dal = new EvenementDAO();

        public int AjouterEvenement(string intitule, DateTime dateDebut, DateTime dateFin, int idCampagne, string codeInseeVille)
        {
            Evenement p = new Evenement();
            p.Intitule = intitule;
            p.DateDebut = dateDebut;
            p.DateFin = dateFin;
            p.IdCampagne = idCampagne;
            p.CodeInseeVille = codeInseeVille;
            return dal.AjouterEvenement(p);
        }

        public int ModifierEvenement(Evenement p)
        {

            return dal.ModifierEvenement(p);
        }

        public int SupprimerEvenement(Evenement p)
        {

            return dal.SupprimerEvenement(p);
        }

        public List<Evenement> GetLesEvenement()
        {
            return dal.GetLesEvenement();
        }
        public List<Evenement> GetLesEvenementParCampagne(int idCampagne)
        {
            return dal.GetLesEvenementParCampagne(idCampagne);
        }
        public List<string> GetLesErreurs(string intitule, DateTime dateDebut, DateTime dateFin,int selectIndexCampagne, int selectIndexVille)
        {
            List<string> lesErreurs = new List<string>();
            if (!ValidationDonnees.EstChampRempli(intitule))
            {
                lesErreurs.Add("Le nom du produit doit être renseigné");
            }   
            if (dateDebut > dateFin)
            {
                lesErreurs.Add("La date de fin doit être supérieure à la date début");
            }
            if (!ValidationDonnees.EstLigneComboSelectionnee(selectIndexCampagne))
            {
                lesErreurs.Add("Le prix de vente doit être numérique et supérieur à 0");
            }   
            if (!ValidationDonnees.EstLigneComboSelectionnee(selectIndexVille))
            {
                lesErreurs.Add("La catégorie doit être renseignée");
            }
                
            return lesErreurs;
        }
    }
}
