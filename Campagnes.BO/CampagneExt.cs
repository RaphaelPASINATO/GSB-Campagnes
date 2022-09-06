using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campagnes.BO
{
    public partial class Campagne
    {
        public string nomEmploye
        {
            get { return Employe.Nom; }
        }

        public string libelleTypePublic
        {
            get { return TypePublic.Libelle; }
        }

        public string CampagneDebutFin
        {
            get { return this.Intitule + " - " + this.DateDebut.ToShortDateString() + " - " + this.DateFin.ToShortDateString(); }
        }
    }
}
