using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class CampagneDAO
    {
        public List<Campagne> GetLesCampagnes()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Campagnes
                .ToList();
                return liste;
            }
        }

        public List<Campagne> GetLesCampagnesParAgences(int idAgence)
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Campagnes
                .Include("Employe")
                .Include("TypePublic")
                .Where(c => c.IdAgenceCommunication == idAgence || c.IdAgenceArtistique == idAgence)
                .ToList();
                return liste;
            }
        }
        public int AjouterCampagne(Campagne c)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {

                    ctx.sp_campagne_add(c.Intitule, c.Objectif, c.DateDebut, c.DateFin, c.IdTypePublic, c.IdAgenceCommunication, c.IdAgenceArtistique, c.IdEmploye);
                    return 0;
                }
                catch
                {
                    return -1;
                }

            }
        }

        public int ModifierCampagne(Campagne c)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_campagne_update(c.Id, c.Intitule, c.Objectif, c.DateDebut, c.DateFin, c.IdTypePublic, c.IdAgenceCommunication, c.IdAgenceArtistique, c.IdEmploye);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerCampagne(Campagne c)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_campagne_delete(c.Id);
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
