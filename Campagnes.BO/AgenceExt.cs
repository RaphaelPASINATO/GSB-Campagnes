﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campagnes.BO
{
    public partial class Agence
    {
        public string nomVille
        {
            //get { return Ville.Nom; }
            get { return this.Ville.Nom + " " + this.Ville.CodePostal; }

        }
    }
}
