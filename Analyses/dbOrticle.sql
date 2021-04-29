create database dbOrticle
go 

use dbOrticle
go

CREATE TABLE Utilisateur(
    IdUtl INT NOT NULL identity(1,1) ,
    nomUtl NVARCHAR(255) NOT NULL,
    prenomUtl NVARCHAR(255) NOT NULL,
    usernUtl NVARCHAR(255) NOT NULL,
    emailUtl NVARCHAR(255) NOT NULL,
    mdpUtl NVARCHAR(255) NOT NULL,
	CONSTRAINT utilisateur_idutl_primary PRIMARY KEY(IdUtl),
	CONSTRAINT utilisateur_userntl_unique UNIQUE(usernUtl)
);

CREATE TABLE Administrateur(
    IdAdm INT NOT NULL identity(1,1) ,
    nomAdm NVARCHAR(255) NOT NULL,
    prenomAdm NVARCHAR(255) NOT NULL,
    emailAdm NVARCHAR(255) NOT NULL,
    mdpAdm NVARCHAR(255) NOT NULL,
	CONSTRAINT admin_idadm_primary PRIMARY KEY(IdAdm)
);

CREATE TABLE categorie(
    IdCat INT NOT NULL identity(1,1) ,
    nomCat NVARCHAR(255) NOT NULL,
	CONSTRAINT categorie_idcat_primary PRIMARY KEY("IdCat")
);

CREATE TABLE Orticle(
    IdOrt INT NOT NULL identity(1,1) ,
    IdCat INT NOT NULL,
    IdUtl INT NOT NULL,
    sourceOrt NVARCHAR(255) NOT NULL,
    titreOrt NVARCHAR(255) NOT NULL,
    dateOrt DATE NOT NULL,
    nbLike INT NOT NULL,
	CONSTRAINT orticle_idort_primary PRIMARY KEY(IdOrt),
	CONSTRAINT orticle_idcat_foreign FOREIGN KEY(IdCat) REFERENCES categorie(IdCat),
	CONSTRAINT orticle_idutl_foreign FOREIGN KEY(IdUtl) REFERENCES Utilisateur(IdUtl)
);

CREATE TABLE Article(
    IdArticle INT NOT NULL identity(1,1) ,
    IdUtl INT NOT NULL,
    sourceUtl NVARCHAR(255) NOT NULL,
    titreUtl NVARCHAR(255) NOT NULL,
    dateArt DATE NOT NULL,
    extraitArt NVARCHAR(255) NOT NULL,
	CONSTRAINT article_idarticle_primary PRIMARY KEY(IdArticle),
	CONSTRAINT article_idutl_foreign FOREIGN KEY(IdUtl) REFERENCES Utilisateur(IdUtl)
);

CREATE TABLE idee(
    IdIdee INT NOT NULL identity(1,1) ,
    IdOrt INT NOT NULL,
    titreIde NVARCHAR(255) NOT NULL,
    corpsIde NVARCHAR(255) NOT NULL,
	CONSTRAINT idee_ididee_primary PRIMARY KEY(IdIdee),
	CONSTRAINT idee_idort_foreign FOREIGN KEY(IdOrt) REFERENCES Orticle(IdOrt)
);

CREATE TABLE signalOrt(
    IdSig INT NOT NULL identity(1,1) ,
    IdOrt INT NOT NULL,
    IdUtl INT NOT NULL,
    nbSug INT NOT NULL,
    dateOrt DATE NOT NULL,
    statusSig INT NOT NULL,
	CONSTRAINT signalort_idsig_primary PRIMARY KEY(IdSig),
	CONSTRAINT signalort_idort_foreign FOREIGN KEY(IdOrt) REFERENCES Orticle(IdOrt),
	CONSTRAINT signalort_idutl_foreign FOREIGN KEY(IdUtl) REFERENCES Utilisateur(IdUtl)
);

CREATE TABLE support(
    IdSup INT NOT NULL identity(1,1) ,
    nomSup NVARCHAR(255) NOT NULL,
    prenomSup NVARCHAR(255) NOT NULL,
    emailSup NVARCHAR(255) NOT NULL,
    msgSup NVARCHAR(255) NOT NULL
);