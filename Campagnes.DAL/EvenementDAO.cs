using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using System.Data;

namespace Campagnes.DAL
{
    public class EvenementDAO
    {
        public int AjouterEvenement(Evenement p)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_evenement_add(p.Intitule, p.DateDebut, p.DateFin, p.IdCampagne, p.CodeInseeVille);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public int ModifierEvenement(Evenement p)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_evenement_update(p.Id, p.Intitule, p.DateDebut, p.DateFin, p.IdCampagne, p.CodeInseeVille);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public int SupprimerEvenement(Evenement p)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_evenement_delete(p.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public List<Evenement> GetLesEvenement()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Evenements 
                .ToList();
                return liste;
            }
        }
        public List<Evenement> GetLesEvenementParCampagne(int idCampagne)
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Evenements
                    .Include("Ville")
                    .Where(p => p.Campagne.Id == idCampagne)
                    .ToList();
                    return liste;
            }
        }
    }
}
