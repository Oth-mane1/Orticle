USE master
GO

CREATE LOGIN publicloginUser
WITH password='pub1.lic2.lo3.gi4.n';
GO

USE dbOrticle
GO

CREATE USER publicUser FROM LOGIN publicloginUser;
GO

EXEC sp_addrolemember 'db_owner', 'publicUser';