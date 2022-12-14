USE [master]
GO
/****** Object:  Database [Campagnes]    Script Date: 07/04/2021 15:20:05 ******/
CREATE DATABASE [Campagnes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Campagnes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Campagnes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Campagnes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Campagnes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Campagnes] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Campagnes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Campagnes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Campagnes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Campagnes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Campagnes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Campagnes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Campagnes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Campagnes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Campagnes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Campagnes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Campagnes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Campagnes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Campagnes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Campagnes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Campagnes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Campagnes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Campagnes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Campagnes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Campagnes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Campagnes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Campagnes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Campagnes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Campagnes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Campagnes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Campagnes] SET  MULTI_USER 
GO
ALTER DATABASE [Campagnes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Campagnes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Campagnes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Campagnes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Campagnes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Campagnes] SET QUERY_STORE = OFF
GO
USE [Campagnes]
GO
/****** Object:  Table [dbo].[Agence]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NOT NULL,
	[Adresse] [varchar](255) NOT NULL,
	[Telephone] [char](10) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[SiteWeb] [varchar](255) NULL,
	[CodeInseeVille] [char](5) NOT NULL,
	[SpecialiteAgence] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artiste]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artiste](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NOT NULL,
	[SiteWeb] [varchar](255) NULL,
	[IdCourantArtistique] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campagne]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campagne](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Intitule] [varchar](255) NOT NULL,
	[Objectif] [varchar](255) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[DateFin] [date] NOT NULL,
	[IdTypePublic] [int] NOT NULL,
	[IdAgenceCommunication] [int] NULL,
	[IdAgenceArtistique] [int] NULL,
	[IdEmploye] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategorieVip]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategorieVip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourantArtistique]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourantArtistique](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](100) NOT NULL,
	[Prenom] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evenement]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evenement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Intitule] [varchar](255) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[DateFin] [date] NOT NULL,
	[IdCampagne] [int] NOT NULL,
	[CodeInseeVille] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fonctionnalite]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fonctionnalite](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[identifiantMenu] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habilitation]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habilitation](
	[IdProfil] [int] NOT NULL,
	[IdFonctionnalite] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProfil] ASC,
	[IdFonctionnalite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invitation]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invitation](
	[IdVip] [int] NOT NULL,
	[IdEvenement] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVip] ASC,
	[IdEvenement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Objet] [varchar](255) NOT NULL,
	[Corps] [varchar](500) NULL,
	[IdCategorieVip] [int] NOT NULL,
	[IdEvenement] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participation]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participation](
	[IdEvenement] [int] NOT NULL,
	[IdArtiste] [int] NOT NULL,
	[Cachet] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEvenement] ASC,
	[IdArtiste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profil]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Intitule] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraceIntervention]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraceIntervention](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomTable] [varchar](100) NOT NULL,
	[OperationEffectuee] [varchar](255) NOT NULL,
	[DateHeure] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypePublic]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypePublic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](100) NOT NULL,
	[Prenom] [varchar](100) NOT NULL,
	[Pseudo] [varchar](20) NOT NULL,
	[Mdp] [varchar](20) NOT NULL,
	[IdProfil] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ville](
	[CodeInsee] [char](5) NOT NULL,
	[Nom] [varchar](100) NOT NULL,
	[Arrondissement] [varchar](10) NULL,
	[CodePostal] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeInsee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vip]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](100) NOT NULL,
	[Adresse] [varchar](255) NOT NULL,
	[Mail] [varchar](255) NULL,
	[IdCategorieVip] [int] NOT NULL,
	[CodeInseeVille] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Agence] ON 

INSERT [dbo].[Agence] ([Id], [Nom], [Adresse], [Telephone], [Email], [SiteWeb], [CodeInseeVille], [SpecialiteAgence]) VALUES (1, N'Riofluo Activité', N'7 rue jules Ferry', N'0951028276', N'sophie.henry@riofluo.com', N'http:// www.riofluo.com', N'93006', N'Artistique     ')
INSERT [dbo].[Agence] ([Id], [Nom], [Adresse], [Telephone], [Email], [SiteWeb], [CodeInseeVille], [SpecialiteAgence]) VALUES (2, N'Novell’art', N'6, rue Déodat de Severac', N'0686214715', N'stephanie.novello@novellart.com', N'http:// www.novellart.com', N'75117', N'Artistique     ')
INSERT [dbo].[Agence] ([Id], [Nom], [Adresse], [Telephone], [Email], [SiteWeb], [CodeInseeVille], [SpecialiteAgence]) VALUES (3, N'LJ communication', N'16 rue de l''arcade', N'0145038989', N'paul.pierrat@ljcom.net', N'http:// www.ljcom.net', N'75108', N'Communication  ')
INSERT [dbo].[Agence] ([Id], [Nom], [Adresse], [Telephone], [Email], [SiteWeb], [CodeInseeVille], [SpecialiteAgence]) VALUES (4, N'Image & stratégie', N'30 rue Fortuny', N'0142896500', N'bruno.fuchs@image-strategie.com', N'http:// www.image-strategie.com', N'75117', N'Communication  ')
SET IDENTITY_INSERT [dbo].[Agence] OFF
GO
SET IDENTITY_INSERT [dbo].[Artiste] ON 

INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (1, N'Skull', N'www.skull.com', 1)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (2, N'Hopare', N'www.h-Hopare.com', 1)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (3, N'Shaka', N'www.shaka1.fr', 1)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (4, N'Piccinini', N'www.piccinini.fr', 2)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (5, N'Orlan', N'http://www.orlan.eu', 2)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (6, N'Stelarc', N'http://www.stelarc.va.com.au', 2)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (7, N'Bruno Montpied', N'http://www.montpied.fr', 3)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (8, N'Agusil', N'https://www.facebook.com/marc.gonzalezlopez.9', 4)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (9, N'Bibi', N'http://www.bibi.fr/', 6)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (10, N'Pierrick Sorin', N'https://www.facebook.com/PierrickSorinOfficiel', 6)
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (11, N'Cécile Plaisance', N'http://www.cecileplaisance.com', 6)
SET IDENTITY_INSERT [dbo].[Artiste] OFF
GO
SET IDENTITY_INSERT [dbo].[Campagne] ON 

INSERT [dbo].[Campagne] ([Id], [Intitule], [Objectif], [DateDebut], [DateFin], [IdTypePublic], [IdAgenceCommunication], [IdAgenceArtistique], [IdEmploye]) VALUES (1, N'Médicaments sans médecin : attention, danger !', N'Les dangers de l’achat de médicaments sur Internet', CAST(N'2021-01-01' AS Date), CAST(N'2021-03-31' AS Date), 1, 3, NULL, 3)
INSERT [dbo].[Campagne] ([Id], [Intitule], [Objectif], [DateDebut], [DateFin], [IdTypePublic], [IdAgenceCommunication], [IdAgenceArtistique], [IdEmploye]) VALUES (2, N'Prendre ou reprendre le contrôle de son asthme', N'Apprendre les gestes simples pour maîtriser les symptômes et prévenir les crises', CAST(N'2021-01-31' AS Date), CAST(N'2021-04-15' AS Date), 1, NULL, 1, 2)
SET IDENTITY_INSERT [dbo].[Campagne] OFF
GO
SET IDENTITY_INSERT [dbo].[CategorieVip] ON 

INSERT [dbo].[CategorieVip] ([Id], [Libelle]) VALUES (1, N'Journaliste')
INSERT [dbo].[CategorieVip] ([Id], [Libelle]) VALUES (2, N'Médecin')
INSERT [dbo].[CategorieVip] ([Id], [Libelle]) VALUES (3, N'Pharmacien')
INSERT [dbo].[CategorieVip] ([Id], [Libelle]) VALUES (4, N'Ministre')
INSERT [dbo].[CategorieVip] ([Id], [Libelle]) VALUES (5, N'Député')
SET IDENTITY_INSERT [dbo].[CategorieVip] OFF
GO
SET IDENTITY_INSERT [dbo].[CourantArtistique] ON 

INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (1, N'Street art')
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (2, N'Bio art')
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (3, N'Art Brut')
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (4, N'Action painting')
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (5, N'Optical art')
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (6, N'Installation')
SET IDENTITY_INSERT [dbo].[CourantArtistique] OFF
GO
SET IDENTITY_INSERT [dbo].[Employe] ON 

INSERT [dbo].[Employe] ([Id], [Nom], [Prenom]) VALUES (1, N'BONDY', N'Frédéric')
INSERT [dbo].[Employe] ([Id], [Nom], [Prenom]) VALUES (2, N'COLLET', N'Alizée')
INSERT [dbo].[Employe] ([Id], [Nom], [Prenom]) VALUES (3, N'THARAUD', N'Pascale')
INSERT [dbo].[Employe] ([Id], [Nom], [Prenom]) VALUES (4, N'GRUNY', N'Paul')
INSERT [dbo].[Employe] ([Id], [Nom], [Prenom]) VALUES (5, N'NORMAN', N'Vincent')
SET IDENTITY_INSERT [dbo].[Employe] OFF
GO
SET IDENTITY_INSERT [dbo].[Fonctionnalite] ON 

INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (1, N'btnAjouterCampagne')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (2, N'btnGererEvenements')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (3, N'btnConsulterListeCampagneParAgence')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (4, N'btnAjouterEvenement')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (5, N'btnGererCampagnes')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (6, N'btnConsulterListeEvenementParCampagne')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (7, N'btnAjouterVip')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (8, N'btnGererVip')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (9, N'btnImporterCsv')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (10, N'btnGererAgence')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (11, N'btnAjouterAgence')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (12, N'btnConsulterListeAgence')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (13, N'btnAfficherAgenceParVille')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (14, N'btnAjouterArtiste')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (15, N'btnGererArtiste')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (16, N'btnConsulterListeArtiste')
INSERT [dbo].[Fonctionnalite] ([Id], [identifiantMenu]) VALUES (17, N'btnConsulterListeVip')
SET IDENTITY_INSERT [dbo].[Fonctionnalite] OFF
GO
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 1)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 2)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 4)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 5)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 7)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 8)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 9)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 10)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 11)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 13)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 14)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 15)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (1, 17)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (2, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (2, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (2, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (2, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (2, 17)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 1)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 2)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 4)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 5)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 7)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 8)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 9)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 10)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 11)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 13)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 14)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 15)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (3, 17)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 1)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 2)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 4)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 5)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 10)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 11)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 13)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 14)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 15)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (4, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 7)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 8)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 9)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (5, 17)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 3)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 6)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 7)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 8)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 9)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 12)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 16)
INSERT [dbo].[Habilitation] ([IdProfil], [IdFonctionnalite]) VALUES (6, 17)
GO
SET IDENTITY_INSERT [dbo].[Profil] ON 

INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (1, N'gestion')
INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (2, N'consultation')
INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (3, N'admin')
INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (4, N'service communication')
INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (5, N'directeur financier')
INSERT [dbo].[Profil] ([Id], [Intitule]) VALUES (6, N'directeur commercial')
SET IDENTITY_INSERT [dbo].[Profil] OFF
GO
SET IDENTITY_INSERT [dbo].[TraceIntervention] ON 

INSERT [dbo].[TraceIntervention] ([Id], [NomTable], [OperationEffectuee], [DateHeure]) VALUES (21, N'Artiste', N'UPDATE', CAST(N'2021-03-30T08:37:15.103' AS DateTime))
INSERT [dbo].[TraceIntervention] ([Id], [NomTable], [OperationEffectuee], [DateHeure]) VALUES (22, N'Artiste', N'UPDATE', CAST(N'2021-03-30T08:49:16.880' AS DateTime))
INSERT [dbo].[TraceIntervention] ([Id], [NomTable], [OperationEffectuee], [DateHeure]) VALUES (23, N'Artiste', N'DELETE', CAST(N'2021-04-01T14:34:12.667' AS DateTime))
SET IDENTITY_INSERT [dbo].[TraceIntervention] OFF
GO
SET IDENTITY_INSERT [dbo].[TypePublic] ON 

INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (1, N'Tout public')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (2, N'Enfants')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (3, N'Adolescents')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (4, N'Jeunes adultes')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (5, N'Adultes')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (6, N'Séniors')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (7, N'Femmes')
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (8, N'Hommes')
SET IDENTITY_INSERT [dbo].[TypePublic] OFF
GO
SET IDENTITY_INSERT [dbo].[Utilisateur] ON 

INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (3, N'Dupont', N'Jean', N'admin', N'123', 1)
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (4, N'Dubois', N'Marine', N'util', N'123', 2)
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (5, N'Dupont', N'Laurine', N'laurine', N'123', 3)
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (6, N'Macron', N'Emmanuel', N'emmanuel', N'123', 4)
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (7, N'Delamare', N'Julien', N'julien', N'123', 5)
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Pseudo], [Mdp], [IdProfil]) VALUES (8, N'*moinet', N'Emilie', N'emilie', N'123', 6)
SET IDENTITY_INSERT [dbo].[Utilisateur] OFF
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'33063', N'Bordeaux', N'', N'33000')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'59350', N'Lille', N'', N'59000')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'63113', N'Clermont-Ferrand', N'', N'63000')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'67482', N'Strasbourg', N'', N'67000')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'69381', N'Lyon', N'1er', N'69001')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'69388', N'Lyon', N'8ème', N'69008')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'75108', N'Paris', N'8ème', N'75008')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'75114', N'Paris', N'14ème', N'75014')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'75117', N'Paris', N'16ème', N'75017')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'92036', N'Gennevilliers', N'', N'92230')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'92050', N'Nanterre', N'', N'92000')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'93006', N'Bagnolet', N'', N'93170')
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'94003', N'Arcueil', N'', N'94110')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Agence__A9D10534D316C8A8]    Script Date: 07/04/2021 15:20:05 ******/
ALTER TABLE [dbo].[Agence] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Utilisat__F1433CEFD69C8DED]    Script Date: 07/04/2021 15:20:05 ******/
ALTER TABLE [dbo].[Utilisateur] ADD UNIQUE NONCLUSTERED 
(
	[Pseudo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Participation] ADD  DEFAULT ((0)) FOR [Cachet]
GO
ALTER TABLE [dbo].[TraceIntervention] ADD  DEFAULT (sysutcdatetime()) FOR [DateHeure]
GO
ALTER TABLE [dbo].[Agence]  WITH CHECK ADD FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
ALTER TABLE [dbo].[Artiste]  WITH CHECK ADD FOREIGN KEY([IdCourantArtistique])
REFERENCES [dbo].[CourantArtistique] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdAgenceCommunication])
REFERENCES [dbo].[Agence] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdAgenceArtistique])
REFERENCES [dbo].[Agence] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdEmploye])
REFERENCES [dbo].[Employe] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdTypePublic])
REFERENCES [dbo].[TypePublic] ([Id])
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD FOREIGN KEY([IdCampagne])
REFERENCES [dbo].[Campagne] ([Id])
GO
ALTER TABLE [dbo].[Habilitation]  WITH CHECK ADD FOREIGN KEY([IdFonctionnalite])
REFERENCES [dbo].[Fonctionnalite] ([Id])
GO
ALTER TABLE [dbo].[Habilitation]  WITH CHECK ADD FOREIGN KEY([IdProfil])
REFERENCES [dbo].[Profil] ([Id])
GO
ALTER TABLE [dbo].[Invitation]  WITH CHECK ADD FOREIGN KEY([IdEvenement])
REFERENCES [dbo].[Evenement] ([Id])
GO
ALTER TABLE [dbo].[Invitation]  WITH CHECK ADD FOREIGN KEY([IdVip])
REFERENCES [dbo].[Vip] ([Id])
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD FOREIGN KEY([IdCategorieVip])
REFERENCES [dbo].[CategorieVip] ([Id])
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD FOREIGN KEY([IdEvenement])
REFERENCES [dbo].[Evenement] ([Id])
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD FOREIGN KEY([IdArtiste])
REFERENCES [dbo].[Artiste] ([Id])
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD FOREIGN KEY([IdEvenement])
REFERENCES [dbo].[Evenement] ([Id])
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD FOREIGN KEY([IdProfil])
REFERENCES [dbo].[Profil] ([Id])
GO
ALTER TABLE [dbo].[Vip]  WITH CHECK ADD FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
ALTER TABLE [dbo].[Vip]  WITH CHECK ADD FOREIGN KEY([IdCategorieVip])
REFERENCES [dbo].[CategorieVip] ([Id])
GO
ALTER TABLE [dbo].[Agence]  WITH CHECK ADD CHECK  (([SpecialiteAgence]='Artistique' OR [SpecialiteAgence]='Communication'))
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_add] (
	@Nom VARCHAR(50),
	@Adresse VARCHAR(100),
	@Telephone VARCHAR(10),
	@Email VARCHAR(50),
	@SiteWeb VARCHAR(100),
	@CodeInseeVille CHAR(5),
	@SpecialiteAgence VARCHAR(20)
)
AS
BEGIN
	INSERT INTO Agence(Nom, Adresse, Telephone, Email, SiteWeb, CodeInseeVille, SpecialiteAgence) VALUES(@Nom, @Adresse, @Telephone, @Email, @SiteWeb, @CodeInseeVille, @SpecialiteAgence)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_delete] ( @Id INT )
AS
BEGIN
	DELETE FROM Agence
	WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_update]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_update] (@Id INT, @Nom VARCHAR(50), @Adresse VARCHAR(100), @Telephone VARCHAR(10), @Email VARCHAR(50), @SiteWeb VARCHAR(100), @CodeInseeVille CHAR(5), @SpecialiteAgence VARCHAR(20))
AS
BEGIN
	UPDATE Agence SET
	Nom = @Nom,
	Adresse = @Adresse,
	Telephone = @Telephone,
	Email = @Email,
	SiteWeb = @SiteWeb,
	CodeInseeVille = @CodeInseeVille,
	SpecialiteAgence = @SpecialiteAgence
	WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_artiste_add](@nom varchar(50), @siteWeb char(255), @IdCourantArtistique int)
as
begin
	insert into Artiste(Nom, SiteWeb, IdCourantArtistique) values(@nom, @siteWeb, @IdCourantArtistique)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_artiste_delete](@id int)
as
begin
	delete from Artiste
	where Id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_update]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_artiste_update](@id int, @nom varchar(50), @siteWeb varchar(50), @IdCourantArtistique int)
as
begin
	update Artiste
	set Nom = @nom, siteWeb = @siteWeb, IdCourantArtistique = @IdCourantArtistique
	where Id = @id
end



GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_campagne_add]
	(@Intitule varchar(255),
	@Objectif varchar(255),
	@dateDebut date,
	@dateFin date,
	@IdTypePublic int,
	@IdAgenceCommunication int,
	@IdAgenceArtistique int,
	@IdEmploye int)
as
	insert into Campagne (Intitule, Objectif, DateDebut, DateFin, IdEmploye, IdTypePublic, IdAgenceCommunication, IdAgenceArtistique ) 
	values (@Intitule, @Objectif, @dateDebut, @dateFin, @IdEmploye,@IdTypePublic,@IdAgenceCommunication, @IdAgenceArtistique);

GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_campagne_delete]
	@Id int
as
	delete from Campagne
	where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_update]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_campagne_update]
	(@Id int,
	@Intitule varchar(255),
	@Objectif varchar(255),
	@dateDebut date,
	@dateFin date,
	@IdTypePublic int,
	@IdAgenceCommunication int,
	@IdAgenceArtistique int,
	@IdEmploye int)
as 
	update Campagne
	set Intitule = @Intitule, Objectif = @Objectif, DateDebut = @dateDebut, DateFin = @dateFin, IdTypePublic = @IdTypePublic, IdAgenceCommunication = @IdAgenceCommunication, IdAgenceArtistique = @IdAgenceArtistique, IdEmploye = @IdEmploye
	where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_evenement_add] (@Intitule varchar(255), @DateDebut date, @DateFin date, @IdCampagne int, @CodeInseeVille char(5))
as
begin
insert into Evenement(Intitule, DateDebut, DateFin, IdCampagne, CodeInseeVille) values(@Intitule, @DateDebut, @DateFin, @IdCampagne, @CodeInseeVille)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_evenement_delete](@Id int)
as
begin
   	SET NOCOUNT ON;
   	DELETE FROM Evenement
         	WHERE Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_update]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_evenement_update] (@Id int, @Intitule varchar(255), @DateDebut date, @DateFin date, @IdCampagne int, @CodeInseeVille char(5))
as
begin
   	SET NOCOUNT ON;
   	UPDATE Evenement
         	SET Intitule = @Intitule,
         	DateDebut = @DateDebut,
         	DateFin = @DateFin,
         	IdCampagne = @IdCampagne,
         	CodeInseeVille = @CodeInseeVille
         	where Id =@Id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_nombreAgenceParVilles]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_nombreAgenceParVilles]
AS
BEGIN
	SELECT Ville.Nom, COUNT(Id) AS NbAgence
	FROM Agence
	RIGHT JOIN Ville ON CodeInseeVille = Ville.CodeInsee
	GROUP BY Ville.Nom
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ville_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ville_add](@codeInsee char(5), @nom varchar(100), @arrondissement varchar(100),@codePostal char(5))
as
BEGIN
	insert into ville(CodeInsee, Nom, Arrondissement, CodePostal) values(@codeInsee, @nom, @arrondissement, @codePostal);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_vip_add]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_vip_add](@Nom varchar(100), @Adresse varchar(255), @Mail varchar(255),@IdCategorieVip int, @CodeInseeVille char(5))
as
BEGIN
	insert into Vip(Nom, Adresse, Mail, IdCategorieVip, CodeInseeVille) values(@Nom, @Adresse, @Mail, @IdCategorieVip, @CodeInseeVille);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_vip_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_vip_delete] (@Id int)
as
BEGIN
 DELETE FROM Vip
 WHERE Id = @Id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_vip_update]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_vip_update](@Id int, @Nom varchar(100),  @Adresse varchar(255), @Mail varchar(255),@IdCategorieVip int, @CodeInseeVille char(5))
as
BEGIN
	UPDATE Vip set
	Nom = @Nom,
	Adresse = @Adresse,
	Mail = @Mail,
	IdCategorieVip = @IdCategorieVip,
	CodeInseeVille = @CodeInseeVille
	WHERE Id = @Id
END

GO
/****** Object:  Trigger [dbo].[tr_Agence_delete]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tr_Agence_delete]
ON [dbo].[Agence]
FOR DELETE
AS
INSERT INTO TraceIntervention (NomTable,OperationEffectuee,DateHeure) VALUES('Agence','DELETE',GETDATE())
GO
ALTER TABLE [dbo].[Agence] ENABLE TRIGGER [tr_Agence_delete]
GO
/****** Object:  Trigger [dbo].[tr_Agence_insert]    Script Date: 07/04/2021 15:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tr_Agence_insert]
ON [dbo].[Agence]
FOR INSERT
AS
INSERT INTO TraceIntervention (NomTable,OperationEffectuee,DateHeure) VALUES('Agence','INSERT',GETDATE())

GO
ALTER TABLE [dbo].[Agence] ENABLE TRIGGER [tr_Agence_insert]
GO
/****** Object:  Trigger [dbo].[tr_Agence_Update]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tr_Agence_Update]
ON [dbo].[Agence]
FOR UPDATE
AS
INSERT INTO TraceIntervention (NomTable,OperationEffectuee,DateHeure) VALUES('Agence','UPDATE',GETDATE())

GO
ALTER TABLE [dbo].[Agence] ENABLE TRIGGER [tr_Agence_Update]
GO
/****** Object:  Trigger [dbo].[tr_artiste_delete]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_artiste_delete]
On [dbo].[Artiste]
for delete
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'DELETE', GETDATE())


GO
ALTER TABLE [dbo].[Artiste] ENABLE TRIGGER [tr_artiste_delete]
GO
/****** Object:  Trigger [dbo].[tr_artiste_insert]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_artiste_insert]
On [dbo].[Artiste]
for insert
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'INSERT', GETDATE())



GO
ALTER TABLE [dbo].[Artiste] ENABLE TRIGGER [tr_artiste_insert]
GO
/****** Object:  Trigger [dbo].[tr_artiste_update]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_artiste_update]
On [dbo].[Artiste]
for update
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'UPDATE', GETDATE())

GO
ALTER TABLE [dbo].[Artiste] ENABLE TRIGGER [tr_artiste_update]
GO
/****** Object:  Trigger [dbo].[tr_campagne_delete]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_campagne_delete]
On [dbo].[Campagne]
for delete
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Campagne', 'DELETE', GETDATE())



GO
ALTER TABLE [dbo].[Campagne] ENABLE TRIGGER [tr_campagne_delete]
GO
/****** Object:  Trigger [dbo].[tr_campagne_insert]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_campagne_insert]
On [dbo].[Campagne]
for insert
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Campagne', 'INSERT', GETDATE())

GO
ALTER TABLE [dbo].[Campagne] ENABLE TRIGGER [tr_campagne_insert]
GO
/****** Object:  Trigger [dbo].[tr_campagne_update]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_campagne_update]
On [dbo].[Campagne]
for update
as
insert into TraceIntervention (NomTable, OperationEffectuee, DateHeure) values('Campagne', 'UPDATE', GETDATE())
GO
ALTER TABLE [dbo].[Campagne] ENABLE TRIGGER [tr_campagne_update]
GO
/****** Object:  Trigger [dbo].[tr_Evenement_delete]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_Evenement_delete]
on [dbo].[Evenement]
for delete
as
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values ('Evenement','DELETE',GetDate())

GO
ALTER TABLE [dbo].[Evenement] ENABLE TRIGGER [tr_Evenement_delete]
GO
/****** Object:  Trigger [dbo].[tr_Evenement_insert]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_Evenement_insert]
on [dbo].[Evenement]
for insert
as
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values ('Evenement','INSERT',GetDate())
 
GO
ALTER TABLE [dbo].[Evenement] ENABLE TRIGGER [tr_Evenement_insert]
GO
/****** Object:  Trigger [dbo].[tr_Evenement_update]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_Evenement_update]
on [dbo].[Evenement]
for update
as
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values ('Evenement','UPDATE',GetDate())

GO
ALTER TABLE [dbo].[Evenement] ENABLE TRIGGER [tr_Evenement_update]
GO
/****** Object:  Trigger [dbo].[tr_Vip_delete]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tr_Vip_delete]
on [dbo].[Vip]
for delete
as 
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values('Vip','DELETE',GETDATE())



GO
ALTER TABLE [dbo].[Vip] ENABLE TRIGGER [tr_Vip_delete]
GO
/****** Object:  Trigger [dbo].[tr_Vip_insert]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_Vip_insert]
on [dbo].[Vip]
for insert
as
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values('Vip','INSERT',GETDATE())

GO
ALTER TABLE [dbo].[Vip] ENABLE TRIGGER [tr_Vip_insert]
GO
/****** Object:  Trigger [dbo].[tr_Vip_update]    Script Date: 07/04/2021 15:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_Vip_update]
on [dbo].[Vip]
for update
as 
insert into TraceIntervention (NomTable,OperationEffectuee,DateHeure) values('Vip','UPDATE',GETDATE())


GO
ALTER TABLE [dbo].[Vip] ENABLE TRIGGER [tr_Vip_update]
GO
USE [master]
GO
ALTER DATABASE [Campagnes] SET  READ_WRITE 
GO
