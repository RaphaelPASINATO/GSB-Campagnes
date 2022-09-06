using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class CategorieVipDAO
    {
        public List<CategorieVip> GetLesCategories()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.CategorieVips
                    .ToList();               
                return liste;
            }
        }
    }
}
