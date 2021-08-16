-- Admin
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrateur](
	[IdAdm] [int] IDENTITY(1,1) NOT NULL,
	[nomAdm] [nvarchar](255) NOT NULL,
	[prenomAdm] [nvarchar](255) NOT NULL,
	[emailAdm] [nvarchar](255) NOT NULL,
	[mdpAdm] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrateur] ADD  CONSTRAINT [admin_idadm_primary] PRIMARY KEY CLUSTERED 
(
	[IdAdm] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

-- Article 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[IdArticle] [int] IDENTITY(1,1) NOT NULL,
	[IdUtl] [int] NOT NULL,
	[sourceUtl] [nvarchar](255) NOT NULL,
	[titreUtl] [nvarchar](255) NOT NULL,
	[dateArt] [datetime] NULL,
	[extraitArt] [nvarchar](505) NULL,
	[shortSrcArt] [nvarchar](255) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [article_idarticle_primary] PRIMARY KEY CLUSTERED 
(
	[IdArticle] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [article_idutl_foreign] FOREIGN KEY([IdUtl])
REFERENCES [dbo].[Utilisateur] ([IdUtl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [article_idutl_foreign]
GO

-- Categorie
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorie](
	[idCat] [int] NOT NULL,
	[nomCat] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[categorie] ADD  CONSTRAINT [pk_idcat] PRIMARY KEY CLUSTERED 
(
	[idCat] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

-- Idee
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idee](
	[IdIdee] [int] IDENTITY(1,1) NOT NULL,
	[IdOrt] [int] NOT NULL,
	[titreIde] [nvarchar](255) NOT NULL,
	[corpsIde] [nvarchar](2000) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[idee] ADD  CONSTRAINT [idee_ididee_primary] PRIMARY KEY CLUSTERED 
(
	[IdIdee] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[idee]  WITH NOCHECK ADD  CONSTRAINT [idee_idort_foreign] FOREIGN KEY([IdOrt])
REFERENCES [dbo].[Orticle] ([IdOrt])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[idee] CHECK CONSTRAINT [idee_idort_foreign]
GO

-- LikedOrticle
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[likedOrt](
	[IdUtl] [int] NOT NULL,
	[IdOrt] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[likedOrt] ADD  CONSTRAINT [PK_LikedUtl] PRIMARY KEY CLUSTERED 
(
	[IdUtl] ASC,
	[IdOrt] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[likedOrt]  WITH CHECK ADD  CONSTRAINT [liked_idUtl_primary] FOREIGN KEY([IdUtl])
REFERENCES [dbo].[Utilisateur] ([IdUtl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[likedOrt] CHECK CONSTRAINT [liked_idUtl_primary]
GO

-- Orticle
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orticle](
	[IdOrt] [int] IDENTITY(1,1) NOT NULL,
	[IdCat] [int] NOT NULL,
	[IdUtl] [int] NOT NULL,
	[sourceOrt] [nvarchar](255) NOT NULL,
	[titreOrt] [nvarchar](255) NOT NULL,
	[dateOrt] [datetime] NULL,
	[nbLike] [int] NOT NULL,
	[shortSrcOrt] [nvarchar](255) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orticle] ADD  CONSTRAINT [orticle_idort_primary] PRIMARY KEY CLUSTERED 
(
	[IdOrt] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orticle]  WITH CHECK ADD  CONSTRAINT [orticle_idcat_foreign] FOREIGN KEY([IdCat])
REFERENCES [dbo].[categorie] ([idCat])
GO
ALTER TABLE [dbo].[Orticle] CHECK CONSTRAINT [orticle_idcat_foreign]
GO
ALTER TABLE [dbo].[Orticle]  WITH CHECK ADD  CONSTRAINT [orticle_idutl_foreign] FOREIGN KEY([IdUtl])
REFERENCES [dbo].[Utilisateur] ([IdUtl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orticle] CHECK CONSTRAINT [orticle_idutl_foreign]
GO

-- Signal Orticle
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[signalOrt](
	[IdSig] [int] IDENTITY(1,1) NOT NULL,
	[IdOrt] [int] NOT NULL,
	[IdUtl] [int] NULL,
	[nbSug] [int] NOT NULL,
	[statusSig] [int] NOT NULL,
	[dateSig] [datetime] NOT NULL,
	[descSig] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[signalOrt] ADD  CONSTRAINT [signalort_idsig_primary] PRIMARY KEY CLUSTERED 
(
	[IdSig] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[signalOrt]  WITH CHECK ADD  CONSTRAINT [signalort_idort_foreign] FOREIGN KEY([IdOrt])
REFERENCES [dbo].[Orticle] ([IdOrt])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[signalOrt] CHECK CONSTRAINT [signalort_idort_foreign]
GO

-- Support
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[support](
	[IdSup] [int] IDENTITY(1,1) NOT NULL,
	[nomSup] [nvarchar](255) NOT NULL,
	[prenomSup] [nvarchar](255) NOT NULL,
	[emailSup] [nvarchar](255) NOT NULL,
	[msgSup] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[support] ADD  CONSTRAINT [PK_support] PRIMARY KEY CLUSTERED 
(
	[IdSup] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

-- Utilisateur
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[IdUtl] [int] IDENTITY(1,1) NOT NULL,
	[nomUtl] [nvarchar](255) NOT NULL,
	[prenomUtl] [nvarchar](255) NOT NULL,
	[usernUtl] [nvarchar](255) NOT NULL,
	[emailUtl] [nvarchar](255) NOT NULL,
	[mdpUtl] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Utilisateur] ADD  CONSTRAINT [utilisateur_idutl_primary] PRIMARY KEY CLUSTERED 
(
	[IdUtl] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[Utilisateur] ADD  CONSTRAINT [utilisateur_userntl_unique] UNIQUE NONCLUSTERED 
(
	[usernUtl] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

-- Utilisateur Fav
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilisateurFav](
	[idUtl] [int] NOT NULL,
	[idCat] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UtilisateurFav] ADD  CONSTRAINT [PK_UtlFav] PRIMARY KEY CLUSTERED 
(
	[idUtl] ASC,
	[idCat] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UtilisateurFav]  WITH CHECK ADD  CONSTRAINT [FK_Cat] FOREIGN KEY([idCat])
REFERENCES [dbo].[categorie] ([idCat])
GO
ALTER TABLE [dbo].[UtilisateurFav] CHECK CONSTRAINT [FK_Cat]
GO
ALTER TABLE [dbo].[UtilisateurFav]  WITH CHECK ADD  CONSTRAINT [FK_Utl] FOREIGN KEY([idUtl])
REFERENCES [dbo].[Utilisateur] ([IdUtl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilisateurFav] CHECK CONSTRAINT [FK_Utl]
GO
