using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campagnes.BLL
{
    class ValidationDonnees
    {
        // Vérifie qu'une valeur est renseignée
        public static bool EstChampRempli(string valeur)
        {
            return !String.IsNullOrWhiteSpace(valeur);
        }
        // Vérifie que la valeur passée en paramètre est un type décimal supérieur à 0
        public static bool EstDecimalNonNul(string valeur)
        {
            decimal valDec;
            return Decimal.TryParse(valeur, out valDec) && valDec > 0;
        }
        // Vérifie que la valeur passée en paramètre est différente de -1
        public static bool EstLigneComboSelectionnee(int selectedIndex)
        {
            return selectedIndex != -1;
        }

        public static bool EstBoutonRadioSelectionnee(string valeur)
        {
            return !String.IsNullOrEmpty(valeur);
        }
    }
}
