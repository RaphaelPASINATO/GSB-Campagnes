using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campagnes.BO
{
    public partial class Ville
    {
        public string NomVille
        {
            get { return this.Nom + " " + this.CodePostal; }
        }
    }
}
