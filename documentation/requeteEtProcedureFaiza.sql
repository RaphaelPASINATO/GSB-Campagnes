select * from Fonctionnalite

insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('Dupont', 'Jean',
'admin', '123', 1)
insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('Dupont', 'Laurine',
'laurine', '123', 3)
insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('Macron', 'Emmanuel',
'emmanuel', '123', 4)
insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('Delamare', 'Julien',
'julien', '123', 5)
insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('*moinet', 'Emilie',
'emilie', '123', 6)
insert into Utilisateur(Nom, Prenom, Pseudo, Mdp, IdProfil) values('Dubois', 'Marine',
'util', '123', 2)

insert into Profil(Intitule) values ('admin')
insert into Profil(Intitule) values ('service communication')
insert into Profil(Intitule) values ('directeur financier')
insert into Profil(Intitule) values ('directeur commercial')

insert into Fonctionnalite(identifiantMenu) values('btnConsulterListeVip')

insert into Habilitation(IdFonctionnalite, IdProfil) values(1, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(2, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(3, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(4, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(5, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(6, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(7, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(8, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(9, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(10, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(11, 4)
insert into Habilitation(IdFonctionnalite, IdProfil) values(12, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(13, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(14, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(15, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(16, 1)
insert into Habilitation(IdFonctionnalite, IdProfil) values(17, 1)

insert into Habilitation(IdFonctionnalite, IdProfil) values(3, 2)
insert into Habilitation(IdFonctionnalite, IdProfil) values(6, 2)
insert into Habilitation(IdFonctionnalite, IdProfil) values(12, 2)
insert into Habilitation(IdFonctionnalite, IdProfil) values(16, 2)
insert into Habilitation(IdFonctionnalite, IdProfil) values(17, 2)

insert into Habilitation(IdFonctionnalite, IdProfil) values(3,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(6,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(7,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(8,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(9,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(12,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(16,5)
insert into Habilitation(IdFonctionnalite, IdProfil) values(17,5)

insert into Habilitation(IdFonctionnalite, IdProfil) values(3,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(6,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(12,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(8,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(7,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(9,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(17,6)
insert into Habilitation(IdFonctionnalite, IdProfil) values(16,6)


delete from Profil where id = 1

select * from Habilitation
select * from Profil
select * from Utilisateur
delete from Habilitation
where IdProfil=2 and IdFonctionnalite = 4

CREATE PROCEDURE sp_artiste_add(@nom varchar(50), @siteWeb char(255), @IdCourantArtistique int)
as
begin
	insert into Artiste(Nom, SiteWeb, IdCourantArtistique) values(@nom, @siteWeb, @IdCourantArtistique)
end



go

CREATE PROCEDURE sp_artiste_update(@id int, @nom varchar(50), @siteWeb varchar(50), @IdCourantArtistique int)
as
begin
	update Artiste
	set Nom = @nom, siteWeb = @siteWeb, IdCourantArtistique = @IdCourantArtistique
	where Id = @id
end



go

CREATE PROCEDURE sp_artiste_delete(@id int)
as
begin
	delete from Artiste
	where Id = @id
end

select * from TraceIntervention

Create trigger tr_artiste_insert
On Artiste
for insert
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'INSERT', GETDATE())


Alter trigger tr_artiste_update
On Artiste
for update
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'UPDATE', GETDATE())

Create trigger tr_artiste_delete
On Artiste
for delete
as
insert into TraceIntervention (nomTable, operationEffectuee, dateHeure) values('Artiste', 'DELETE', GETDATE())

select * from Artiste

select * from TraceIntervention