using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class VipDAO
    {
        public List<Vip> GetLesVipParCategorie(int idCategorie)
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Vips
                .Include("Ville")
                .Include("CategorieVip")
                .Where(v => v.IdCategorieVip == idCategorie)
                .ToList();
                return liste;
            }
        }

        public int AjouterVip (Vip v)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    //exec sp_ajoutVip 'allo', 'adresse', 'mail@', 1, '63113'
                   
                    ctx.sp_vip_add(v.Nom, v.Adresse, v.Mail, v.IdCategorieVip, v.CodeInseeVille); 
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int ModifierVip (Vip v)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_vip_update(v.Id, v.Nom, v.Adresse, v.Mail, v.IdCategorieVip, v.CodeInseeVille);
                    return 0;

                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerVip(Vip v)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_vip_delete(v.Id);
                    return 0;

                }
                catch
                {
                    return -1;
                }
            }
        }

        public List<Vip> GetLesVips()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Vips
                    .ToList();
                return liste;
            }
        }


    }
}
