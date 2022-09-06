using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;

namespace Campagnes.DAL
{
    public class VilleDAO
    {
        public List<Ville> GetLesVilles()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Villes
                    .ToList();
                return liste;
            }
        }

        public int AjouterVille(Ville v)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {

                    ctx.sp_ville_add(v.CodeInsee, v.Nom, v.Arrondissement, v.CodePostal);
                    return 0;
                }
                catch (Exception e)
                {
                    return -1;
                }
            }
        }
    }
}
