using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class UtilisateurDAO
    {
        public Utilisateur InfosUtilisateur(string Pseudo, string motpasse)
        {
            using (var ctx = new CampagnesEntities())
            {
                return ctx.Utilisateurs
                .Where(u => u.Pseudo == Pseudo && u.Mdp == motpasse)
                .SingleOrDefault();
            }
        }

        public List<Fonctionnalite> GetLesFonctionnalitesAutorisees(string Pseudo)
        {
            using (var ctx = new CampagnesEntities())
            {
                // Récupère le DBSet Utilisteurs (tous les utilisateurs)
                var liste = ctx.Utilisateurs

                // Sélectionne l'utilisateur ayant pour login celui passé en paramètre
                .Where(u => u.Pseudo == Pseudo)

                // Récupère le profil de cet utilisateur
                .Select(u => u.Profil)

                // Récupère un DbSet contenant toutes les fonctionnalités associées
                // à ce profil
                .SelectMany(p => p.Fonctionnalites)

                // Convertit le DataSet<Fonctionnalite> en List<Fonctionnalite>
                .ToList();
                return liste;
            }
        }
    }
}
