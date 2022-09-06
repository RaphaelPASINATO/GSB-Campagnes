using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.DAL;
using Campagnes.BO;


namespace Campagnes.BLL
{
    public class VilleManager
    {
        private VilleDAO dal = new VilleDAO();
        public List<Ville> GetLesVilles()
        {
            return dal.GetLesVilles();
        }

        public int AjouterVille(string codeInsee, string nom, string arrondissement, string codePostal)
        {
            Ville v = new Ville();
            v.Nom = nom;
            v.CodeInsee = codeInsee;
            v.Arrondissement = arrondissement;
            v.CodePostal = codePostal;
            return dal.AjouterVille(v);
        }
    }
}
