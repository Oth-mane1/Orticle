-- Users --
CREATE PROCEDURE createUser 
@nom NVARCHAR(255), @prenom NVARCHAR(255), @usrname NVARCHAR(255), @mail NVARCHAR(255), @mdp NVARCHAR(255)
AS
	IF(dbo.checkUser(@usrname) = 0)
	BEGIN
		INSERT INTO Utilisateur 
		VALUES(
			@nom,
			@prenom,
			@usrname,
			@mail,
			@mdp
		)
	END
	ELSE
		THROW 55555, 'le nom d''utilisateur existe déja', 11
GO

CREATE PROCEDURE getUserInfos @id INT
AS
	SELECT * FROM Utilisateur
	WHERE Utilisateur.IdUtl = @id
GO

CREATE PROCEDURE updateUser
@usrID INT, @nom NVARCHAR(255), @prenom NVARCHAR(255), @usrname NVARCHAR(255), @mail NVARCHAR(255), @mdp NVARCHAR(255)
AS
	IF(dbo.checkUser(@usrname) = 0)
	BEGIN
		UPDATE Utilisateur 
		SET nomUtl = @nom,
			prenomUtl = @prenom,
			usernUtl = @usrname,
			emailUtl = @mail,
			mdpUtl = @mdp
		WHERE IdUtl = @usrID
	END
	ELSE
		THROW 55555, 'le nom d''utilisateur existe déja', 0
GO

CREATE PROCEDURE deleteUser @id INT
AS
	DELETE FROM Utilisateur
	WHERE Utilisateur.IdUtl = @id
GO

CREATE FUNCTION checkUser (@userName NVARCHAR(255))
RETURNS INT AS
BEGIN
	DECLARE @ex INT
	IF EXISTS(SELECT IdUtl FROM Utilisateur WHERE Utilisateur.usernUtl = @userName)
		SET @ex = 1
	ELSE
		SET @ex = 0

	Return @ex
END
GO

CREATE PROCEDURE connectUser
@usrname NVARCHAR(255), @mdp NVARCHAR(255),@state INT output
AS
	IF exists(SELECT * from utilisateur where usernUtl=@usrname)
	BEGIN
	   IF exists(SELECT * from utilisateur where usernUtl=@usrname and mdpUtl=@mdp)
	      set @state=1
	
		ELSE
		  set @state=0
	END
	ELSE
		THROW 55555, 'le nom d''utilisateur n''existe pas', 2
GO


-- Article --
CREATE PROCEDURE getArticle @id INT
AS
	SELECT * FROM Article
	WHERE Article.IdArticle = @id
GO

CREATE PROCEDURE createArticle 
@IdUtl int, @sourceArt NVARCHAR(255), @titreArt NVARCHAR(255), @dateArt Date, @extraitArt NVARCHAR(255)
AS
	INSERT INTO Article
	VALUES(
			@IdUtl,
			@sourceArt,
			@titreArt,
			@dateArt,
			@extraitArt
	)
GO

CREATE PROCEDURE deleteArticle @id INT
AS
	DELETE FROM Article
	WHERE Article.IdArticle = @id
GO

--Orticle--
CREATE PROCEDURE getOrticle @id INT
AS
	SELECT * FROM Orticle
	WHERE Orticle.IdOrt = @id
GO

CREATE PROCEDURE dbo.createOrticle 
@IdCat int, @IdUtl int, @sourceOrt nvarchar(255), @titreOrt nvarchar(255), @nbLike int
AS
	INSERT INTO Orticle
	VALUES(
			@IdCat,
			@IdUtl,
			@sourceOrt,
			@titreOrt,
			GETDATE(),
			0
		)
GO

CREATE PROCEDURE deleteOrticle @id INT
AS
	DELETE FROM Orticle
	WHERE Orticle.IdOrt = @id
GO

--Idée--
CREATE PROCEDURE getIdee @id INT
AS
	SELECT * FROM idee
	WHERE idee.IdIdee = @id
GO

CREATE PROCEDURE createIdee
@IdOrt int, @titreIde NVARCHAR(255), @corpsIde NVARCHAR(255)
AS
	INSERT INTO Idee
	VALUES(
			@IdOrt,
			@titreIde,
			@corpsIde
	)
GO

CREATE PROCEDURE deleteIdee @id INT
AS
	DELETE FROM idee
	WHERE idee.IdIdee = @id
GO


--Support--
CREATE PROCEDURE getSupport @id INT
AS
	SELECT * FROM Support
	WHERE support.IdSup = @id
GO

CREATE PROCEDURE createSupport
 @nomSup NVARCHAR(255), @prenomSup NVARCHAR(255),@emailSup NVARCHAR(255), @msgSup NVARCHAR(255)
AS
	INSERT INTO Support
	VALUES(
			@nomSup,
			@prenomSup,
			@emailSup,
			@msgSup
	)
GO

CREATE PROCEDURE deleteSupport @id INT
AS
	DELETE FROM support
	WHERE support.IdSup = @id
GO

--Administrateur--
CREATE PROCEDURE createAdmin
@nom NVARCHAR(255), @prenom NVARCHAR(255), @mail NVARCHAR(255), @mdp NVARCHAR(255)
AS
		INSERT INTO Administrateur 
		VALUES(
			@nom,
			@prenom,
			@mail,
			@mdp
		)
	
GO

CREATE PROCEDURE getAdminInfos @id INT
AS
	SELECT * FROM Administrateur
	WHERE Administrateur.IdAdm = @id
GO

CREATE PROCEDURE updateAdmin
@usrID INT, @nom NVARCHAR(255), @prenom NVARCHAR(255), @mail NVARCHAR(255), @mdp NVARCHAR(255)
AS
		UPDATE Administrateur 
		SET nomAdm = @nom,
			prenomAdm = @prenom,
			emailAdm = @mail,
			mdpAdm = @mdp
		WHERE IdAdm = @usrID
GO

CREATE PROCEDURE deleteAdmin @id INT
AS
	DELETE FROM Administrateur
	WHERE Administrateur.IdAdm = @id
GO

CREATE PROCEDURE connectAdmin
@email NVARCHAR(255), @mdp NVARCHAR(255),@state INT output
AS
	IF exists(SELECT * from Administrateur where emailAdm=@email)
	BEGIN
	   IF exists(SELECT * from Administrateur where emailAdm=@email and mdpAdm=@mdp)
	      set @state=1
	
		ELSE
		  set @state=0
	END
	ELSE
		THROW 55555, 'E-mail incorrect', 2
GO