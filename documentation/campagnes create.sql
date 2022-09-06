use master
go
CREATE DATABASE Campagnes
go
GO
USE Campagnes
GO

/*------------------------------------------------------------
-- Table: TraceIntervention
------------------------------------------------------------*/
CREATE TABLE TraceIntervention(
	Id             			INT IDENTITY (1,1) NOT NULL ,
	NomTable       			VARCHAR (100) NOT NULL ,
	OperationEffectuee		VARCHAR (255) NOT NULL ,
	DateHeure      			DATETIME DEFAULT SYSUTCDATETIME( ) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Campagne
------------------------------------------------------------*/
CREATE TABLE Campagne(
	Id              		INT IDENTITY (1,1) NOT NULL ,
	Intitule        		VARCHAR (255) NOT NULL ,
	Objectif        		VARCHAR (255) NOT NULL ,
	DateDebut       		DATE NOT NULL ,
	DateFin         		DATE NOT NULL ,
	IdTypePublic       		INT  NOT NULL ,
	IdAgenceCommunication	INT ,
	IdAgenceArtistique 		INT ,
	IdEmploye      			INT  NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Ville
------------------------------------------------------------*/
CREATE TABLE Ville(
	CodeInsee		CHAR (5)  NOT NULL ,
	Nom				VARCHAR (100) NOT NULL ,
	Arrondissement  VARCHAR (10) NULL ,
	CodePostal		CHAR (5)  NOT NULL ,
	PRIMARY KEY (codeInsee)
);
GO
/*------------------------------------------------------------
-- Table: Evenement
------------------------------------------------------------*/
CREATE TABLE Evenement(
	Id             INT IDENTITY (1,1) NOT NULL ,
	Intitule       VARCHAR (255) NOT NULL ,
	DateDebut      DATE NOT NULL ,
	DateFin        DATE NOT NULL ,
	IdCampagne     INT NOT NULL ,
	CodeInseeVille CHAR (5) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Vip
------------------------------------------------------------*/
CREATE TABLE Vip(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Nom             VARCHAR (100) NOT NULL ,
	Adresse         VARCHAR (255) NOT NULL ,
	Mail            VARCHAR (255)  ,
	IdCategorieVip  INT  NOT NULL ,
	CodeInseeVille  CHAR (5)  NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Artiste
------------------------------------------------------------*/
CREATE TABLE Artiste(
	Id                   INT IDENTITY (1,1) NOT NULL ,
	Nom           		 VARCHAR (255) NOT NULL ,
	SiteWeb              VARCHAR (255)  ,
	IdCourantArtistique  INT  NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: CourantArtistique
------------------------------------------------------------*/
CREATE TABLE CourantArtistique(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Libelle         VARCHAR (255) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: TypePublic
------------------------------------------------------------*/
CREATE TABLE TypePublic(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Libelle         VARCHAR (255) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Employe
------------------------------------------------------------*/
CREATE TABLE Employe(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Nom             VARCHAR (100) NOT NULL ,
	Prenom          VARCHAR (100) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Agence
------------------------------------------------------------*/
CREATE TABLE Agence(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Nom             VARCHAR (255) NOT NULL ,
	Adresse         CHAR (255)  NOT NULL ,
	Telephone       CHAR (10)  NOT NULL ,
	Email           VARCHAR (255) NOT NULL UNIQUE,
	SiteWeb         VARCHAR (255)  ,
	CodeInseeVille  CHAR (5) NOT NULL ,
	SpecialiteAgence CHAR (15) CHECK (SpecialiteAgence IN ('Communication', 'Artistique'))
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: CategorieVip
------------------------------------------------------------*/
CREATE TABLE CategorieVip(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Libelle         VARCHAR (255) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Message
------------------------------------------------------------*/
CREATE TABLE Message(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Objet           VARCHAR (255) NOT NULL ,
	Corps           VARCHAR (500)  ,
	IdCategorieVip  INT  NOT NULL ,
	IdEvenement     INT  NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Fonctionnalite
------------------------------------------------------------*/
CREATE TABLE Fonctionnalite(
	Id              INT IDENTITY (1,1) NOT NULL ,
	identifiantMenu VARCHAR (255) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Profil
------------------------------------------------------------*/
CREATE TABLE Profil(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Intitule        VARCHAR (255) NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Utilisateur
------------------------------------------------------------*/
CREATE TABLE Utilisateur(
	Id              INT IDENTITY (1,1) NOT NULL ,
	Nom             VARCHAR (100) NOT NULL ,
	Prenom          VARCHAR (100) NOT NULL ,
	Pseudo      	VARCHAR (20) NOT NULL UNIQUE,
	Mdp             VARCHAR (20) NOT NULL ,
	IdProfil        INT NOT NULL ,
	PRIMARY KEY (Id)
);
GO
/*------------------------------------------------------------
-- Table: Inviter
------------------------------------------------------------*/
CREATE TABLE Invitation(
	IdVip           INT NOT NULL ,
	IdEvenement     INT NOT NULL ,
	PRIMARY KEY (IdVip,IdEvenement)
);
GO
/*------------------------------------------------------------
-- Table: Habiliter
------------------------------------------------------------*/
CREATE TABLE Habilitation(
	IdProfil         INT NOT NULL ,
	IdFonctionnalite INT NOT NULL ,
	PRIMARY KEY (IdProfil,IdFonctionnalite)
);
GO
/*------------------------------------------------------------
-- Table: Participer
------------------------------------------------------------*/
CREATE TABLE Participation(
	IdEvenement 	INT  NOT NULL ,
	IdArtiste   	INT  NOT NULL ,
	Cachet          MONEY DEFAULT 0,
	PRIMARY KEY (IdEvenement,IdArtiste)
);
GO


ALTER TABLE Campagne 		ADD FOREIGN KEY (IdAgenceCommunication) REFERENCES Agence(Id);
ALTER TABLE Campagne 		ADD FOREIGN KEY (IdAgenceArtistique) REFERENCES Agence(Id);
ALTER TABLE Campagne 		ADD FOREIGN KEY (IdEmploye) REFERENCES Employe(Id);
ALTER TABLE Campagne 		ADD FOREIGN KEY (IdTypePublic) REFERENCES TypePublic(Id);
ALTER TABLE Evenement 		ADD FOREIGN KEY (IdCampagne) REFERENCES Campagne(Id);
ALTER TABLE Evenement 		ADD FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee);
ALTER TABLE Vip 			ADD FOREIGN KEY (IdCategorieVip) REFERENCES CategorieVip(Id);
ALTER TABLE Vip 			ADD FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee);
ALTER TABLE Artiste 		ADD FOREIGN KEY (IdCourantArtistique) REFERENCES CourantArtistique(Id);
ALTER TABLE Agence 			ADD FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee);
ALTER TABLE Message 		ADD FOREIGN KEY (IdCategorieVip) REFERENCES CategorieVip(Id);
ALTER TABLE Message 		ADD FOREIGN KEY (IdEvenement) REFERENCES Evenement(Id);
ALTER TABLE Utilisateur 	ADD FOREIGN KEY (IdProfil) REFERENCES Profil(Id);
ALTER TABLE Invitation  	ADD FOREIGN KEY (IdVip) REFERENCES Vip(Id);
ALTER TABLE Invitation 		ADD FOREIGN KEY (IdEvenement) REFERENCES Evenement(Id);
ALTER TABLE Habilitation 	ADD FOREIGN KEY (IdProfil) REFERENCES Profil(Id);
ALTER TABLE Habilitation 	ADD FOREIGN KEY (IdFonctionnalite) REFERENCES Fonctionnalite(Id);
ALTER TABLE Participation 	ADD FOREIGN KEY (IdEvenement) REFERENCES Evenement(Id);
ALTER TABLE Participation 	ADD FOREIGN KEY (IdArtiste) REFERENCES Artiste(Id);

