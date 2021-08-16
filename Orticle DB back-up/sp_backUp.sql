SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[connectUser]
@usrname NVARCHAR(255), @mdp NVARCHAR(255)
AS
	IF exists(SELECT * from utilisateur where usernUtl=@usrname)
	BEGIN
	   IF exists(SELECT * from utilisateur where usernUtl=@usrname and mdpUtl=@mdp)
	      return 1
		ELSE
		  return 0
	END
	ELSE
		return -1
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[connectAdmin]
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createSupport]
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Users --
CREATE PROCEDURE [dbo].[createUser] 
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
		return (SELECT idUtl FROM Utilisateur WHERE usernUtl = @usrname)
	END
	ELSE
		return -1
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Users Favorite --
CREATE PROCEDURE [dbo].[createUserFav] 
@userId INT, @cat1 INT, @cat2 INT, @cat3 INT
AS
	INSERT INTO UtilisateurFav 
	VALUES 
	(@userId, @cat1),
	(@userId, @cat2),
	(@userId, @cat3)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Administrateur--
CREATE PROCEDURE [dbo].[createAdmin]
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createArticle] 
@IdUtl int, @sourceArt NVARCHAR(255), @shortsrcArt NVARCHAR(255), @titreArt NVARCHAR(255), @dateArt DateTime = null, @extraitArt NVARCHAR(505)
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createIdee]
@IdOrt int, @titreIde NVARCHAR(255), @corpsIde NVARCHAR(255)
AS
	INSERT INTO Idee
	VALUES(
			@IdOrt,
			@titreIde,
			@corpsIde
	)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createOrticle] 
@IdCat int, @IdUtl int, @sourceOrt nvarchar(255), @shortsrcOrt nvarchar(255), @titreOrt nvarchar(255), @nbLike int = 0, @date DATETIME = null
AS
	IF (@date is null)
		set @date = GETDATE()

	INSERT INTO Orticle
	VALUES(
			@IdCat,
			@IdUtl,
			@sourceOrt,
			@titreOrt,
			@date,
			@nbLike,
			@shortsrcOrt
		)

	RETURN SCOPE_IDENTITY()
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteAdmin] @id INT
AS
	DELETE FROM Administrateur
	WHERE Administrateur.IdAdm = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteArticle] @id INT
AS
	DELETE FROM Article
	WHERE Article.IdArticle = @id
	RETURN 1
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteIdee] @id INT
AS
	DELETE FROM idee
	WHERE idee.IdIdee = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[deleteOrticle] @id INT
AS
	DELETE FROM Orticle
	WHERE Orticle.IdOrt = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteSupport] @id INT
AS
	DELETE FROM support
	WHERE support.IdSup = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteUser] @id INT
AS
	DELETE FROM Utilisateur
	WHERE Utilisateur.IdUtl = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[dislikeOrticle] @idOrt INT, @idUser INT
AS
	UPDATE Orticle SET nbLike -= 1 WHERE IdOrt = @idOrt
	DELETE FROM likedOrt WHERE idUtl = @idUser AND idOrt = @idOrt
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAdminInfos] @id INT
AS
	SELECT * FROM Administrateur
	WHERE Administrateur.IdAdm = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllOrticle] @id INT
AS
	SELECT * FROM Orticle
	WHERE Orticle.IdOrt = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Article --
CREATE PROCEDURE [dbo].[getArticle] @id INT
AS
	SELECT * FROM Article
	WHERE Article.IdArticle = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Catégorie--
CREATE PROCEDURE [dbo].[getCategory] @id INT, @min INT = 0, @max INT = null
AS
	IF (@max is null)
	BEGIN
		SET @max = (SELECT COUNT(*) FROM Orticle)
		IF (@max = 0)
			SET @max = 1
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getDayArticle]
AS
	SELECT TOP(1) *
	FROM Article
	WHERE dateArt >= CAST(GETDATE() AS Date )
	ORDER BY dateArt DESC
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDayOrticle]
AS
	DECLARE @id INT
	SET @id = 
	(SELECT TOP(1) o.IdOrt
	FROM Orticle o
	WHERE dateOrt >= CAST(GETDATE() AS Date) AND nblike = (SELECT MAX(nbLike) FROM orticle WHERE dateOrt >= CAST(GETDATE() AS Date))
	ORDER BY dateOrt DESC)
	
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o
	JOIN categorie c ON c.idCat = o.IdCat
	WHERE o.IdOrt = @id

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Idée--
CREATE PROCEDURE [dbo].[getIdee] @id INT
AS
	SELECT * FROM idee
	WHERE idee.IdIdee = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getOrticle] @id INT, @iduser INT
AS
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.idCat, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o, categorie c
	WHERE o.IdOrt = @id AND o.IdCat = c.idCat

	SELECT i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt = @id

	SELECT *
	FROM likedOrt
	WHERE IdOrt = @id AND IdUtl = @iduser
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Support--
CREATE PROCEDURE [dbo].[getSupport] @id INT
AS
	SELECT * FROM Support
	WHERE support.IdSup = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Article --
CREATE PROCEDURE [dbo].[getUserArticle] @id INT
AS
	SELECT * FROM Article
	WHERE Article.IdUtl = @id
    ORDER BY dateArt DESC
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Explore --
CREATE PROCEDURE [dbo].[getUserExplore] @idUser INT, @min INT = 0, @max INT = null
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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getUserFav] @id INT
AS
	SELECT * FROM UtilisateurFav
	WHERE idUtl = @id
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getUserInfos] @username nvarchar(255)
AS
	SELECT * FROM Utilisateur
	WHERE Utilisateur.usernUtl = @username
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getUserOrticle]
    @id INT
AS
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o, categorie c
	WHERE o.IdUtl = @id AND o.IdCat = c.idCat
    ORDER BY dateOrt DESC

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (SELECT IdOrt FROM Orticle WHERE IdUtl = @id)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getUserSuggest] @offset INT, @count INT
AS
	SELECT o.IdOrt, o.dateOrt, o.nbLike, c.nomCat, o.sourceOrt, o.shortSrcOrt, o.titreOrt
	FROM Orticle o
	JOIN categorie c ON c.idCat = o.IdCat
	ORDER BY o.dateOrt DESC
	offset @offset rows fetch next @count rows only

	SELECT i.IdOrt, i.titreIde, i.corpsIde
	FROM idee i
	WHERE i.IdOrt IN (
		SELECT IdOrt FROM Orticle
		ORDER BY dateOrt DESC 
		offset @offset rows fetch next @count rows only
	)
	
	SELECT *
	FROM Article
	ORDER BY dateArt DESC
	offset @offset rows fetch next @count rows only
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[likeOrticle] @idOrt INT, @idUser INT
AS
	UPDATE Orticle SET nbLike += 1 WHERE IdOrt = @idOrt
	INSERT INTO likedOrt
	VALUES(
		@idUser,
		@idOrt
	)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Users Favorite --
CREATE PROCEDURE [dbo].[updateUserFav] 
@userId NVARCHAR(255), @cat1 NVARCHAR(255), @cat2 NVARCHAR(255), @cat3 NVARCHAR(255)
AS
	DELETE FROM UtilisateurFav
	WHERE idUtl = @userId

	INSERT INTO UtilisateurFav 
	VALUES 
	(@userId, @cat1),
	(@userId, @cat2),
	(@userId, @cat3)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[signalOrticle]
@IdOrt int, @IdUtl int, @descSig nvarchar(255), @dateSig DATETIME = null
AS
	IF (@dateSig is null) SET @dateSig = GETDATE()

    DECLARE @nbSig INT = 0
    DECLARE @statusSig INT = 0

    IF EXISTS (SELECT IdOrt FROM signalOrt WHERE IdOrt = @IdOrt)
    BEGIN
        UPDATE signalOrt SET nbSug += 1 WHERE IdOrt = @IdOrt     
    END
    ELSE
    BEGIN
        INSERT INTO signalOrt
        VALUES(
                @IdOrt,
                @IdUtl,
                @nbSig,
                @statusSig,
                @dateSig,
                @descSig
            )
    END	
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateAdmin]
@usrID INT, @nom NVARCHAR(255), @prenom NVARCHAR(255), @mail NVARCHAR(255), @mdp NVARCHAR(255)
AS
		UPDATE Administrateur 
		SET nomAdm = @nom,
			prenomAdm = @prenom,
			emailAdm = @mail,
			mdpAdm = @mdp
		WHERE IdAdm = @usrID
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[updateUser]
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
