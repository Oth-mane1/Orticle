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
		THROW 55555, 'le nom d''utilisateur existe déja', 0
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

-- Article --
