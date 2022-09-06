using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using Campagnes.DAL;

namespace Campagnes.BLL
{
    public class CampagneManager
    {
        private CampagneDAO dal = new CampagneDAO();

        public List<Campagne> GetLesCampagnes()
        {
            return dal.GetLesCampagnes();
        }

        public List<Campagne> GetLesCampagnesParAgences(int idAgence)
        {
            return dal.GetLesCampagnesParAgences(idAgence);
        }
        public int AjouterCampagne(string intitule, string objectif, DateTime dateDebut, DateTime dateFin, int idTypePublic, Nullable<int> idAgenceCommunication, Nullable<int> idAgenceArtistique, int idEmploye)
        {
            Campagne c = new Campagne();
            c.Intitule = intitule;
            c.Objectif = objectif;
            c.DateDebut = dateDebut;
            c.DateFin = dateFin;
            c.IdTypePublic = idTypePublic;
            c.IdAgenceCommunication = idAgenceCommunication;
            c.IdAgenceArtistique = idAgenceArtistique;
            c.IdEmploye = idEmploye;
            return dal.AjouterCampagne(c);
        }

        public int SupprimerCampagne(Campagne c)
        {
            return dal.SupprimerCampagne(c);
        }

        public int ModifierCampagne(Campagne c)
        {
            return dal.ModifierCampagne(c);
        }

        // Contrôles de saisie de produits
        public List<string> GetLesErreurs(string intitule, string objectif, DateTime dateDebut, DateTime dateFin, int idTypePublic, int idAgenceCommunication, int idAgenceArtistique, int idEmploye)
        {
            List<string> lesErreurs = new List<string>();
            if (!ValidationDonnees.EstChampRempli(intitule))
                lesErreurs.Add("L'intitulé de la campagne doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(objectif))
                lesErreurs.Add("L'objectif de la campagne doit être renseigné");
            if (!ValidationDonnees.EstLigneComboSelectionnee(idAgenceArtistique) && !ValidationDonnees.EstLigneComboSelectionnee(idAgenceCommunication))
                lesErreurs.Add("Veuillez selectionner une agence");
            if (!ValidationDonnees.EstLigneComboSelectionnee(idTypePublic))
                lesErreurs.Add("Veuillez selectionner un type de public");
            if (!ValidationDonnees.EstLigneComboSelectionnee(idEmploye))
                lesErreurs.Add("Veuillez selectionner un employé");
            if (dateDebut > dateFin)
            {
                lesErreurs.Add("La date de début doit être antérieure à la date de fin");
            }

            return lesErreurs;
        }


    }
}
