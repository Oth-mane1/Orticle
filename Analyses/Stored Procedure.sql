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
	IF (@usrname = (SELECT usernUtl FROM Utilisateur WHERE IdUtl = @usrID))
	BEGIN
		UPDATE Utilisateur 
		SET nomUtl = @nom,
			prenomUtl = @prenom,
			emailUtl = @mail,
			mdpUtl = @mdp
		WHERE IdUtl = @usrID
	END
	ELSE
	BEGIN
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
			return -1
	END
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

CREATE PROCEDURE [dbo].[getUserOrticle]
    @id INT
AS
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o, categorie c
	WHERE o.IdUtl = @id AND o.IdCat = c.idCat

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (SELECT IdOrt FROM Orticle WHERE IdUtl = @id)
GO

CREATE PROCEDURE [dbo].[getUserArticle] @id INT
AS
	SELECT * FROM Article
	WHERE Article.IdUtl = @id
GO

-- Explore --
CREATE PROCEDURE getUserExplore @idUser INT, @min INT = 0, @max INT = null
AS
	IF (@max is null)
	BEGIN
		SET @max = (SELECT COUNT(*) FROM Orticle)
	END

	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o
	JOIN categorie c ON c.idCat = o.IdCat
	WHERE o.IdCat IN (SELECT IdCat FROM UtilisateurFav WHERE idUtl = @idUser)
	ORDER BY o.dateOrt DESC
	offset @min rows fetch next @max rows only

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (
		SELECT IdOrt FROM Orticle o 
		WHERE o.IdCat IN (SELECT IdCat FROM UtilisateurFav WHERE idUtl = @idUser) 
		ORDER BY dateOrt DESC 
		offset @min rows fetch next @max rows only
	)
GO

CREATE PROCEDURE getDayOrticle
AS
	SELECT TOP(1) o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o, categorie c
	WHERE nblike = (SELECT MAX(nbLike) FROM orticle)
	ORDER BY dateOrt DESC

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt = (SELECT TOP(1) IdOrt FROM Orticle ORDER BY dateOrt DESC)
GO

CREATE PROCEDURE getDayArticle
AS
	SELECT TOP(1) *
	FROM Article
	ORDER BY dateArt DESC
GO

CREATE PROCEDURE getUserSuggest @min INT = 0, @max INT = null
AS
	IF (@max is null)
	BEGIN
		SET @max = (SELECT COUNT(*) FROM Orticle)
	END

	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o
	JOIN categorie c ON c.idCat = o.IdCat
	ORDER BY o.dateOrt DESC
	offset @min rows fetch next @max rows only

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (
		SELECT IdOrt FROM Orticle
		ORDER BY dateOrt DESC 
		offset @min rows fetch next @max rows only
	)
	
	SELECT *
	FROM Article
	ORDER BY dateArt DESC
	offset @min rows fetch next @max rows only
GO

-- Article --
CREATE PROCEDURE getArticle @id INT
AS
	SELECT * FROM Article
	WHERE Article.IdArticle = @id
GO

CREATE PROCEDURE createArticle 
@IdUtl int, @sourceArt NVARCHAR(255), @shortsrcArt NVARCHAR(255), @titreArt NVARCHAR(255), @dateArt DateTime, @extraitArt NVARCHAR(255)
AS
	IF (@dateArt is null)
		SET @dateArt = GETDATE()

	INSERT INTO Article
	VALUES(
			@IdUtl,
			@sourceArt,
			@titreArt,
			@dateArt,
			@extraitArt,
			@shortsrcArt
	)
GO

CREATE PROCEDURE deleteArticle @id INT
AS
	DELETE FROM Article
	WHERE Article.IdArticle = @id
GO

--Orticle--
CREATE PROCEDURE getAllOrticle @id INT
AS
	SELECT * FROM Orticle
	WHERE Orticle.IdOrt = @id
GO

CREATE PROCEDURE getOrticle @id INT
AS
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.idCat, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o, categorie c
	WHERE o.IdOrt = @id AND o.IdCat = c.idCat

	SELECT i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt = @id
GO

CREATE PROCEDURE dbo.createOrticle 
@IdCat int, @IdUtl int, @sourceOrt nvarchar(255), @shortsrcOrt nvarchar(255), @titreOrt nvarchar(255), @nbLike int = 0, @date DATE = GETDATE
AS
	INSERT INTO Orticle
	VALUES(
			@IdCat,
			@IdUtl,
			@sourceOrt,
			@titreOrt,
			@date,
			@nbLike,
			@sourceOrt
		)
GO

CREATE PROCEDURE deleteOrticle @id INT
AS
	DELETE FROM Orticle
	WHERE Orticle.IdOrt = @id
GO

--Catégorie--
CREATE PROCEDURE getCategory @id INT, @min INT = 0, @max INT = null
AS
	IF (@max is null)
	BEGIN
		SET @max = (SELECT COUNT(*) FROM Orticle)
	END
	
	SELECT nomCat
	FROM categorie
	WHERE idCat = @id

	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o
	JOIN categorie c ON c.idCat = @id
	WHERE o.IdCat = @id
	ORDER BY o.dateOrt DESC
	offset @min rows fetch next @max rows only

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (SELECT IdOrt FROM Orticle WHERE IdCat = @id ORDER BY dateOrt DESC offset @min rows fetch next @max rows only)
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