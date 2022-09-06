using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using Campagnes.DAL;

namespace Campagnes.BLL
{
    public class TypePublicManager
    {
        private TypePublicDAO dal = new TypePublicDAO();

        public List<TypePublic> GetTypePublics()
        {
            return dal.GetTypePublics();
        }
    }
}
