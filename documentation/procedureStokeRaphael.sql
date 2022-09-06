CREATE PROCEDURE sp_vip_add(@Nom varchar(100), @Adresse varchar(255), @Mail varchar(255),@IdCategorieVip int, @CodeInseeVille char(5))
as
BEGIN
	insert into Vip(Nom, Adresse, Mail, IdCategorieVip, CodeInseeVille) values(@Nom, @Adresse, @Mail, @IdCategorieVip, @CodeInseeVille);
END

CREATE PROCEDURE sp_vip_update(@Id int, @Nom varchar(100),  @Adresse varchar(255), @Mail varchar(255),@IdCategorieVip int, @CodeInseeVille char(5))
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

CREATE PROCEDURE sp_vip_delete (@Id int)
as
BEGIN
 DELETE FROM Vip
 WHERE Id = @Id
END