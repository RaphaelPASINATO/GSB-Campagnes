using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using Campagnes.DAL;

namespace Campagnes.BLL
{
    public class EmployeManager
    {
        private EmployeDAO dal = new EmployeDAO();

        public List<Employe> GetLesEmployes()
        {
            return dal.GetLesEmployes();
        }
    }
}
