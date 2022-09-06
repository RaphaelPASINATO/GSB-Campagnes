using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.DAL;
using Campagnes.BO;

namespace Campagnes.BLL
{
    public class CategorieVipManager
    {
        private CategorieVipDAO dal = new CategorieVipDAO();
        public List<CategorieVip> GetLesCategories()
        {
            return dal.GetLesCategories();
        }
    }
}
