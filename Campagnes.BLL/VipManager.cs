using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.DAL;
using Campagnes.BO;

namespace Campagnes.BLL
{
    public class VipManager
    {
        private VipDAO dal = new VipDAO();

        public List<Vip> GetLesVipParCategorie(int idCategorie)
        {
            return dal.GetLesVipParCategorie(idCategorie);
        }


        public int AjouterVip (string nom, string adresse, string mail, int idCategorie, string codeInsee)
        {
            Vip v = new Vip();
            v.Nom = nom;
            v.Adresse = adresse;
            v.Mail = mail;
            v.IdCategorieVip = idCategorie;
            v.CodeInseeVille = codeInsee;
            return dal.AjouterVip(v);
        }

        public int ModifierVip(Vip leVip)
        {
            return dal.ModifierVip(leVip);
        }

        public int SupprimerVip(Vip leVip)
        {
            return dal.SupprimerVip(leVip);
        }

        public List<string> GetLesErreurs(string nom, string adresse, string mail, int idCategorie, int codeInsee)
        {
            List<string> lesErreurs = new List<string>();
            if (!ValidationDonnees.EstChampRempli(nom))
                lesErreurs.Add("Le nom du vip doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(adresse))
                lesErreurs.Add("L'adresse du vip doit être renseigné");
            if (!ValidationDonnees.EstChampRempli(mail))
                lesErreurs.Add("Le mail du vip doit être renseigné");
            if (!ValidationDonnees.EstLigneComboSelectionnee(idCategorie))
                lesErreurs.Add("La catégorie du vip doit être renseignée");
           if (!ValidationDonnees.EstLigneComboSelectionnee(codeInsee))
                lesErreurs.Add("Le code insee du vip doit être renseignée");

            return lesErreurs;
        }

        public List<Vip> GetLesVip()
        {
            return dal.GetLesVips();
        }
    }
}
