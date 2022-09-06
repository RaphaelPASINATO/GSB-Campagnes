using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using Campagnes.DAL;

namespace Campagnes.BLL
{
    public class CourantArtistiqueManager
    {
        private CourantArtistiqueDAO dal = new CourantArtistiqueDAO();

        public List<CourantArtistique> GetLesCourantArtistique()
        {
            return dal.GetLesCourantArtistique();
        }
    }

  
}
