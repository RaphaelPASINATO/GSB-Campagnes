using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using System.Data;

namespace Campagnes.DAL
{
    public class ArtisteDAO
    {
        public List<Artiste> GetLesArtistes()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Artistes
                .ToList();
                return liste;
            }
        }
        public int AjouterArtiste(Artiste a)
        {
            using (var ctx = new CampagnesEntities())
            {

                try
                {
                    ctx.sp_artiste_add(a.Nom, a.SiteWeb, a.IdCourantArtistique);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public List<Artiste> GetLeArtistesParCourantArtistique(int idCourantArtistique)
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Artistes
                .Include("CourantArtistique")
                .Where(a => a.CourantArtistique.Id == idCourantArtistique)
                .ToList();
                return liste;
            }
        }

        public int ModifierArtiste(Artiste a)
        {
            using (var ctx = new CampagnesEntities())
            {
            
                try
                {
                    ctx.sp_artiste_update(a.Id, a.Nom, a.SiteWeb, a.IdCourantArtistique);
                    return 0;
                }
                catch
                {
                    return -1;
                }

            }
        }

        public int SupprimerArtiste(Artiste a)
        {
            using (var ctx = new CampagnesEntities())
            {
             
                try
                {
                    ctx.sp_artiste_delete(a.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }

            }
        }

    }
}
