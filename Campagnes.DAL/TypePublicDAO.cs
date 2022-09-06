using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class TypePublicDAO
    {
        public List<TypePublic> GetTypePublics()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.TypePublics
                .ToList();
                return liste;
            }
        }
    }
}
