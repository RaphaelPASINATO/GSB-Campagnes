using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using System.Data;

namespace Campagnes.DAL
{
    public class CourantArtistiqueDAO
    {
        public List<CourantArtistique> GetLesCourantArtistique()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.CourantArtistiques
                .ToList();
                return liste;
            }
        }
    }
}
