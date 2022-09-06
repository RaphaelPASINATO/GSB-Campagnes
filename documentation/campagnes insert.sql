USE Campagnes
GO

/*------------------------------------------------------------
-- Table: CategorieProduit
------------------------------------------------------------*/
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('33063', 'Bordeaux', '', '33000')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('67482', 'Strasbourg', '', '67000')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('75114', 'Paris', '14ème', '75014')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('63113', 'Clermont-Ferrand', '', '63000')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('69388', 'Lyon', '8ème', '69008')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('59350', 'Lille', '', '59000')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('92036', 'Gennevilliers', '', '92230')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('69381', 'Lyon', '1er', '69001')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('94003', 'Arcueil', '', '94110')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('92050', 'Nanterre', '', '92000')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('93006', 'Bagnolet', '', '93170')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('75117', 'Paris', '16ème', '75017')
INSERT INTO Ville (CodeInsee, Nom, Arrondissement, CodePostal) VALUES('75108', 'Paris', '8ème', '75008')

/*------------------------------------------------------------
-- Table: Agence
------------------------------------------------------------*/
SET IDENTITY_INSERT Agence ON; 
INSERT into Agence (Id, Nom, Adresse, Telephone, Email, SiteWeb, CodeInseeVille, CategorieAgence) VALUES (1, 'Riofluo Activité', '7 rue jules Ferry', '0951028276', 'sophie.henry@riofluo.com', 'http:// www.riofluo.com', '93006', 'Artistique'); 
INSERT into Agence (Id, Nom, Adresse, Telephone, Email, SiteWeb, CodeInseeVille, CategorieAgence) VALUES (2, 'Novell’art', '6, rue Déodat de Severac', '0686214715', 'stephanie.novello@novellart.com', 'http:// www.novellart.com', '75117', 'Artistique');
INSERT into Agence (Id, Nom, Adresse, Telephone, Email, SiteWeb, CodeInseeVille, CategorieAgence) VALUES (3, 'LJ communication', '16 rue de l''arcade', '0145038989', 'paul.pierrat@ljcom.net', 'http:// www.ljcom.net', '75108', 'Communication');
INSERT into Agence (Id, Nom, Adresse, Telephone, Email, SiteWeb, CodeInseeVille, CategorieAgence) VALUES (4, 'Image & stratégie', '30 rue Fortuny', '0142896500', 'bruno.fuchs@image-strategie.com', 'http:// www.image-strategie.com', '75117', 'Communication');
SET IDENTITY_INSERT Agence OFF; 

/*------------------------------------------------------------
-- Table: CourantArtistique
------------------------------------------------------------*/
SET IDENTITY_INSERT CourantArtistique ON;
INSERT INTO CourantArtistique (Id, Libelle) VALUES (1, 'Street art');
INSERT INTO CourantArtistique (Id, Libelle) VALUES (2, 'Bio art');
INSERT INTO CourantArtistique (Id, Libelle) VALUES (3, 'Art Brut');
INSERT INTO CourantArtistique (Id, Libelle) VALUES (4, 'Action painting');
INSERT INTO CourantArtistique (Id, Libelle) VALUES (5, 'Optical art');
INSERT INTO CourantArtistique (Id, Libelle) VALUES (6, 'Installation');
SET IDENTITY_INSERT CourantArtistique OFF;

/*------------------------------------------------------------
-- Table: Artiste
------------------------------------------------------------*/
SET IDENTITY_INSERT Artiste ON;
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (1, 'Skull', 'www.skull.com', 1);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (2, 'Hopare', 'www.hopare.com', 1);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (3, 'Shaka', 'www.shaka1.fr', 1);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (4, 'Piccinini', 'www.piccinini.fr', 2);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (5, 'Orlan', 'http://www.orlan.eu', 2);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (6, 'Stelarc', 'http://www.stelarc.va.com.au', 2);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (7, 'Bruno Montpied', 'http://www.montpied.fr', 3);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (8, 'Agusil', 'https://www.facebook.com/marc.gonzalezlopez.9', 4);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (9, 'Bibi', 'http://www.bibi.fr/', 6);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (10, 'Pierrick Sorin', 'https://www.facebook.com/PierrickSorinOfficiel', 6);
INSERT INTO Artiste (Id, Nom, SiteWeb, IdCourantArtistique) VALUES (11, 'Cécile Plaisance', 'http://www.cecileplaisance.com', 6);
SET IDENTITY_INSERT Artiste OFF;

/*------------------------------------------------------------
-- Table: TypePublic
------------------------------------------------------------*/
SET IDENTITY_INSERT TypePublic ON;
INSERT INTO TypePublic (Id, Libelle) VALUES (1, 'Tout public');
INSERT INTO TypePublic (Id, Libelle) VALUES (2, 'Enfants');
INSERT INTO TypePublic (Id, Libelle) VALUES (3, 'Adolescents');
INSERT INTO TypePublic (Id, Libelle) VALUES (4, 'Jeunes adultes');
INSERT INTO TypePublic (Id, Libelle) VALUES (5, 'Adultes');
INSERT INTO TypePublic (Id, Libelle) VALUES (6, 'Séniors');
INSERT INTO TypePublic (Id, Libelle) VALUES (7, 'Femmes');
INSERT INTO TypePublic (Id, Libelle) VALUES (8, 'Hommes');
SET IDENTITY_INSERT TypePublic OFF;

/*------------------------------------------------------------
-- Table: Employe
------------------------------------------------------------*/
SET IDENTITY_INSERT Employe ON;
INSERT INTO Employe (Id, Nom, Prenom) VALUES (1, 'BONDY', 'Frédéric');
INSERT INTO Employe (Id, Nom, Prenom) VALUES (2, 'COLLET', 'Alizée');
INSERT INTO Employe (Id, Nom, Prenom) VALUES (3, 'THARAUD', 'Pascale');
INSERT INTO Employe (Id, Nom, Prenom) VALUES (4, 'GRUNY', 'Paul');
INSERT INTO Employe (Id, Nom, Prenom) VALUES (5, 'NORMAN', 'Vincent');
SET IDENTITY_INSERT Employe OFF;

/*------------------------------------------------------------
-- Table: CategorieVip
------------------------------------------------------------*/
SET IDENTITY_INSERT CategorieVip ON;
INSERT INTO CategorieVip (Id, Libelle) VALUES (1, 'Journaliste');
INSERT INTO CategorieVip (Id, Libelle) VALUES (2, 'Médecin');
INSERT INTO CategorieVip (Id, Libelle) VALUES (3, 'Pharmacien');
INSERT INTO CategorieVip (Id, Libelle) VALUES (4, 'Ministre');
INSERT INTO CategorieVip (Id, Libelle) VALUES (5, 'Député');
SET IDENTITY_INSERT CategorieVip OFF;


/*------------------------------------------------------------
-- Table: Campagne
------------------------------------------------------------*/
SET IDENTITY_INSERT Campagne ON;
INSERT INTO Campagne(Id, Intitule, Objectif, DateDebut, DateFin, IdTypePublic, IdAgenceCommunication, IdAgenceArtistique, IdEmploye) VALUES (1, 'Médicaments sans médecin : attention, danger !', 'Les dangers de l’achat de médicaments sur Internet', '2021-01-01', '2021-03-31', 1, 3, NULL, 3)
INSERT INTO Campagne(Id, Intitule, Objectif, DateDebut, DateFin, IdTypePublic, IdAgenceCommunication, IdAgenceArtistique, IdEmploye) VALUES (2, 'Prendre ou reprendre le contrôle de son asthme', 'Apprendre les gestes simples pour maîtriser les symptômes et prévenir les crises', '2021-01-31', '2021-04-15', 1, NULL,  1, 2)
SET IDENTITY_INSERT Campagne OFF;






