using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.DAL;
using Campagnes.BO;

namespace Campagnes.BLL
{
    public class UtilisateurManager
    {
        private UtilisateurDAO dal = new UtilisateurDAO();

        public Utilisateur InfosUtilisateur(string Pseudo, string motpasse)
        {
            return dal.InfosUtilisateur(Pseudo, motpasse);
        }

        public List<Fonctionnalite> GetLesFonctionnalitesAutorisees(string Pseudo)
        {
            return dal.GetLesFonctionnalitesAutorisees(Pseudo);
        }

    }

}
