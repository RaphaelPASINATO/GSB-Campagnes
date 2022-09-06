using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campagnes.BO;
using System.Data;

namespace Campagnes.DAL
{
    public class AgenceDAO
    {
        public List<Agence> GetLesAgencesCommunications()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Agences
                .Where(c => c.SpecialiteAgence == "Communication")
                .ToList();
                return liste;
            }
        }

        public List<Agence> GetLesAgencesArtistiques()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Agences
                .Where(c => c.SpecialiteAgence == "Artistique")
                .ToList();
                return liste;
            }
        }

        public List<Agence> GetLesAgencesCamp()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Agences
                .ToList();
                return liste;
            }
        }

        public List<Agence> GetLesAgences()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Agences
                    .Include("Ville")
                    .ToList();
                return liste;
            }

        }

        public List<Ville> GetLesVilles()
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Villes
                    .ToList();
                return liste;
            }
        }
        public List<Agence> GetLesAgencesParSpecialite(string SpecialiteAgence)
        {
            using (var ctx = new CampagnesEntities())
            {
                var liste = ctx.Agences
                    .Include("Ville")
                    .Where(p => p.SpecialiteAgence == SpecialiteAgence)
                    .ToList();
                return liste;
            }
        }

        public int AjouterAgence(Agence a)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_add(a.Nom, a.Adresse, a.Telephone, a.Email, a.SiteWeb, a.CodeInseeVille, a.SpecialiteAgence);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int ModifierAgence(Agence a)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_update(a.Id, a.Nom, a.Adresse, a.Telephone, a.Email, a.SiteWeb, a.CodeInseeVille, a.SpecialiteAgence);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerAgence(Agence a)
        {
            using (var ctx = new CampagnesEntities())
            {
                try
                {
                    ctx.sp_agence_delete(a.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }


        public DataTable GetNombreAgenceParVille()
        {
            // On se connecte à la base de manière habituelle (EF)
            using (var ctx = new CampagnesEntities())
            {
                // On crée un Datatable pour stocker le résultat
                // !!! Nécessite le namespace System.Data !!!
                DataTable dt = new DataTable();

                //On ajoute deux colonnes à ce DataTable
                dt.Columns.Add("NomVille", typeof(string));
                dt.Columns.Add("NbAgence", typeof(int));

                //On crée un objet DbCommand qui sert à exécuter une requête sur la BDD
                var cmd = ctx.Database.Connection.CreateCommand();
                // La propriété CommandText de l'objet DbCommand contient la requête à
                // exécuter : ici, notre procédure stockée
                cmd.CommandText = "sp_nombreAgenceParVilles";

                // On indique qu'il s'agit d'une procédure stockée
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    //On ouvre la connexion à la base de données
                    ctx.Database.Connection.Open();

                    // On exécute la procédure stockée : le résultat est stocké dans un
                    // "lecteur" (un objet DbDataReader) qui va contenir le résultat
                    // de la requête sous la forme d'un ensemble de lignes et de colonnes
                    var reader = cmd.ExecuteReader();

                    //On parcourt le résultat ligne par ligne
                    //Chaque appel à la méthode Read() sur le lecteur, se positionne
                    //sur la ligne suivante du résultat
                    //quand on atteint la fin, la méthode Read() retourne false
                    while (reader.Read())
                    {
                        //On accède au contenu de chaque colonne pour la ligne lue
                        string libelleville = Convert.ToString(reader["Nom"]);
                        int nbAgence = Convert.ToInt32(reader["NbAgence"]);

                        //On stocke les informations récupérées dans une ligne du datatable
                        dt.Rows.Add(libelleville, nbAgence);
                    }
                    //On ferme le lecteur
                    reader.Close();
                }
                finally
                {
                    // On ferme la connexion à la base de données
                    ctx.Database.Connection.Close();
                }
                // Le datatable qui contient maintenant toutes les lignes résultats de la
                // procédure stockée est retourné
                return dt;
            }
        }
    }
}
