using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;

namespace Campagnes.DAL
{
     public class EmployeDAO
    {
        public List<Employe> GetLesEmployes()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Employes
                .ToList();
                return liste;
            }
        }
    }
}
