using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campagnes.BO
{
    public partial class Vip
    {
        public string LibelleCategorie
        {
            get { return CategorieVip.Libelle; }
        }

        public string NomVille
        {
            //get { return Ville.Nom; }
            get { return this.Ville.Nom + " " + this.Ville.CodePostal; }

        }
    }
}
