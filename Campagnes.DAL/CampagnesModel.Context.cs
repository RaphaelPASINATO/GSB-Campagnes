﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Campagnes.BO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CampagnesEntities : DbContext
    {
        public CampagnesEntities()
            : base("name=CampagnesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agence> Agences { get; set; }
        public virtual DbSet<Artiste> Artistes { get; set; }
        public virtual DbSet<Campagne> Campagnes { get; set; }
        public virtual DbSet<CategorieVip> CategorieVips { get; set; }
        public virtual DbSet<CourantArtistique> CourantArtistiques { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Fonctionnalite> Fonctionnalites { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Participation> Participations { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<TraceIntervention> TraceInterventions { get; set; }
        public virtual DbSet<TypePublic> TypePublics { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }
        public virtual DbSet<Vip> Vips { get; set; }
    
        public virtual int sp_artiste_add(string nom, string siteWeb, Nullable<int> idCourantArtistique)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var siteWebParameter = siteWeb != null ?
                new ObjectParameter("siteWeb", siteWeb) :
                new ObjectParameter("siteWeb", typeof(string));
    
            var idCourantArtistiqueParameter = idCourantArtistique.HasValue ?
                new ObjectParameter("IdCourantArtistique", idCourantArtistique) :
                new ObjectParameter("IdCourantArtistique", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_artiste_add", nomParameter, siteWebParameter, idCourantArtistiqueParameter);
        }
    
        public virtual int sp_artiste_delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_artiste_delete", idParameter);
        }
    
        public virtual int sp_artiste_update(Nullable<int> id, string nom, string siteWeb, Nullable<int> idCourantArtistique)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var siteWebParameter = siteWeb != null ?
                new ObjectParameter("siteWeb", siteWeb) :
                new ObjectParameter("siteWeb", typeof(string));
    
            var idCourantArtistiqueParameter = idCourantArtistique.HasValue ?
                new ObjectParameter("IdCourantArtistique", idCourantArtistique) :
                new ObjectParameter("IdCourantArtistique", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_artiste_update", idParameter, nomParameter, siteWebParameter, idCourantArtistiqueParameter);
        }
    
        public virtual int sp_agence_add(string nom, string adresse, string telephone, string email, string siteWeb, string codeInseeVille, string specialiteAgence)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("Telephone", telephone) :
                new ObjectParameter("Telephone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var siteWebParameter = siteWeb != null ?
                new ObjectParameter("SiteWeb", siteWeb) :
                new ObjectParameter("SiteWeb", typeof(string));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            var specialiteAgenceParameter = specialiteAgence != null ?
                new ObjectParameter("SpecialiteAgence", specialiteAgence) :
                new ObjectParameter("SpecialiteAgence", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_agence_add", nomParameter, adresseParameter, telephoneParameter, emailParameter, siteWebParameter, codeInseeVilleParameter, specialiteAgenceParameter);
        }
    
        public virtual int sp_agence_delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_agence_delete", idParameter);
        }
    
        public virtual int sp_agence_update(Nullable<int> id, string nom, string adresse, string telephone, string email, string siteWeb, string codeInseeVille, string specialiteAgence)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("Telephone", telephone) :
                new ObjectParameter("Telephone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var siteWebParameter = siteWeb != null ?
                new ObjectParameter("SiteWeb", siteWeb) :
                new ObjectParameter("SiteWeb", typeof(string));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            var specialiteAgenceParameter = specialiteAgence != null ?
                new ObjectParameter("SpecialiteAgence", specialiteAgence) :
                new ObjectParameter("SpecialiteAgence", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_agence_update", idParameter, nomParameter, adresseParameter, telephoneParameter, emailParameter, siteWebParameter, codeInseeVilleParameter, specialiteAgenceParameter);
        }
    
        public virtual int sp_campagne_add(string intitule, string objectif, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, Nullable<int> idTypePublic, Nullable<int> idAgenceCommunication, Nullable<int> idAgenceArtistique, Nullable<int> idEmploye)
        {
            var intituleParameter = intitule != null ?
                new ObjectParameter("Intitule", intitule) :
                new ObjectParameter("Intitule", typeof(string));
    
            var objectifParameter = objectif != null ?
                new ObjectParameter("Objectif", objectif) :
                new ObjectParameter("Objectif", typeof(string));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            var idTypePublicParameter = idTypePublic.HasValue ?
                new ObjectParameter("IdTypePublic", idTypePublic) :
                new ObjectParameter("IdTypePublic", typeof(int));
    
            var idAgenceCommunicationParameter = idAgenceCommunication.HasValue ?
                new ObjectParameter("IdAgenceCommunication", idAgenceCommunication) :
                new ObjectParameter("IdAgenceCommunication", typeof(int));
    
            var idAgenceArtistiqueParameter = idAgenceArtistique.HasValue ?
                new ObjectParameter("IdAgenceArtistique", idAgenceArtistique) :
                new ObjectParameter("IdAgenceArtistique", typeof(int));
    
            var idEmployeParameter = idEmploye.HasValue ?
                new ObjectParameter("IdEmploye", idEmploye) :
                new ObjectParameter("IdEmploye", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_campagne_add", intituleParameter, objectifParameter, dateDebutParameter, dateFinParameter, idTypePublicParameter, idAgenceCommunicationParameter, idAgenceArtistiqueParameter, idEmployeParameter);
        }
    
        public virtual int sp_campagne_delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_campagne_delete", idParameter);
        }
    
        public virtual int sp_campagne_update(Nullable<int> id, string intitule, string objectif, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, Nullable<int> idTypePublic, Nullable<int> idAgenceCommunication, Nullable<int> idAgenceArtistique, Nullable<int> idEmploye)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var intituleParameter = intitule != null ?
                new ObjectParameter("Intitule", intitule) :
                new ObjectParameter("Intitule", typeof(string));
    
            var objectifParameter = objectif != null ?
                new ObjectParameter("Objectif", objectif) :
                new ObjectParameter("Objectif", typeof(string));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            var idTypePublicParameter = idTypePublic.HasValue ?
                new ObjectParameter("IdTypePublic", idTypePublic) :
                new ObjectParameter("IdTypePublic", typeof(int));
    
            var idAgenceCommunicationParameter = idAgenceCommunication.HasValue ?
                new ObjectParameter("IdAgenceCommunication", idAgenceCommunication) :
                new ObjectParameter("IdAgenceCommunication", typeof(int));
    
            var idAgenceArtistiqueParameter = idAgenceArtistique.HasValue ?
                new ObjectParameter("IdAgenceArtistique", idAgenceArtistique) :
                new ObjectParameter("IdAgenceArtistique", typeof(int));
    
            var idEmployeParameter = idEmploye.HasValue ?
                new ObjectParameter("IdEmploye", idEmploye) :
                new ObjectParameter("IdEmploye", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_campagne_update", idParameter, intituleParameter, objectifParameter, dateDebutParameter, dateFinParameter, idTypePublicParameter, idAgenceCommunicationParameter, idAgenceArtistiqueParameter, idEmployeParameter);
        }
    
        public virtual int sp_evenement_add(string intitule, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, Nullable<int> idCampagne, string codeInseeVille)
        {
            var intituleParameter = intitule != null ?
                new ObjectParameter("Intitule", intitule) :
                new ObjectParameter("Intitule", typeof(string));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("DateDebut", dateDebut) :
                new ObjectParameter("DateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("DateFin", dateFin) :
                new ObjectParameter("DateFin", typeof(System.DateTime));
    
            var idCampagneParameter = idCampagne.HasValue ?
                new ObjectParameter("IdCampagne", idCampagne) :
                new ObjectParameter("IdCampagne", typeof(int));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_evenement_add", intituleParameter, dateDebutParameter, dateFinParameter, idCampagneParameter, codeInseeVilleParameter);
        }
    
        public virtual int sp_evenement_delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_evenement_delete", idParameter);
        }
    
        public virtual int sp_evenement_update(Nullable<int> id, string intitule, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, Nullable<int> idCampagne, string codeInseeVille)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var intituleParameter = intitule != null ?
                new ObjectParameter("Intitule", intitule) :
                new ObjectParameter("Intitule", typeof(string));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("DateDebut", dateDebut) :
                new ObjectParameter("DateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("DateFin", dateFin) :
                new ObjectParameter("DateFin", typeof(System.DateTime));
    
            var idCampagneParameter = idCampagne.HasValue ?
                new ObjectParameter("IdCampagne", idCampagne) :
                new ObjectParameter("IdCampagne", typeof(int));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_evenement_update", idParameter, intituleParameter, dateDebutParameter, dateFinParameter, idCampagneParameter, codeInseeVilleParameter);
        }
    
        public virtual ObjectResult<nombreAgenceParVilles> sp_nombreAgenceParVilles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<nombreAgenceParVilles>("sp_nombreAgenceParVilles");
        }
    
        public virtual int sp_ville_add(string codeInsee, string nom, string arrondissement, string codePostal)
        {
            var codeInseeParameter = codeInsee != null ?
                new ObjectParameter("codeInsee", codeInsee) :
                new ObjectParameter("codeInsee", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var arrondissementParameter = arrondissement != null ?
                new ObjectParameter("arrondissement", arrondissement) :
                new ObjectParameter("arrondissement", typeof(string));
    
            var codePostalParameter = codePostal != null ?
                new ObjectParameter("codePostal", codePostal) :
                new ObjectParameter("codePostal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ville_add", codeInseeParameter, nomParameter, arrondissementParameter, codePostalParameter);
        }
    
        public virtual int sp_vip_add(string nom, string adresse, string mail, Nullable<int> idCategorieVip, string codeInseeVille)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var idCategorieVipParameter = idCategorieVip.HasValue ?
                new ObjectParameter("IdCategorieVip", idCategorieVip) :
                new ObjectParameter("IdCategorieVip", typeof(int));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_vip_add", nomParameter, adresseParameter, mailParameter, idCategorieVipParameter, codeInseeVilleParameter);
        }
    
        public virtual int sp_vip_delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_vip_delete", idParameter);
        }
    
        public virtual int sp_vip_update(Nullable<int> id, string nom, string adresse, string mail, Nullable<int> idCategorieVip, string codeInseeVille)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var idCategorieVipParameter = idCategorieVip.HasValue ?
                new ObjectParameter("IdCategorieVip", idCategorieVip) :
                new ObjectParameter("IdCategorieVip", typeof(int));
    
            var codeInseeVilleParameter = codeInseeVille != null ?
                new ObjectParameter("CodeInseeVille", codeInseeVille) :
                new ObjectParameter("CodeInseeVille", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_vip_update", idParameter, nomParameter, adresseParameter, mailParameter, idCategorieVipParameter, codeInseeVilleParameter);
        }
    }
}