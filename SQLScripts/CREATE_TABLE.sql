USE [Library]
GO

DROP TABLE [Order]
GO

DROP TABLE [Formular]
GO

DROP TABLE [UserLibrary]
GO

DROP TABLE [User]
GO

DROP TABLE [Book]
GO

DROP TABLE [Library]
GO

DROP TABLE [Filial]
GO

DROP TABLE [UserTypes]
GO

CREATE TABLE [Filial]
(
	[Id]		int				PRIMARY KEY NOT NULL,
	[Name]		varchar(100)	NOT NULL,
	[Phone]		varchar(25)		NOT NULL,
	[Address]	varchar(100)	NOT NULL,
)
GO

CREATE TABLE [Library]
(
	[Id]		int		PRIMARY KEY NOT NULL,
	[Name]		varchar(100)	NOT NULL,
	[Phone]		varchar(25)		NOT NULL,
	[Address]	varchar(100)	NOT NULL,
	[IdFilial]	int		FOREIGN KEY REFERENCES [Filial]([Id])
									ON DELETE NO ACTION
									ON UPDATE CASCADE,
)
GO

CREATE TABLE [UserTypes]
(
	[Id]		int			PRIMARY KEY NOT NULL,
	[Type]		varchar(15)	NOT NULL
)
GO

CREATE TABLE [User]
(
	[Id]			int			PRIMARY KEY NOT NULL,
	[Name]			varchar(50)		NULL,
	[SurName]		varchar(50)		NULL,
	[INN]			int				NULL,
	[Address]		varchar(100)	NULL,
	[Phone]			varchar(25)		NULL,
	[Birthday]		date			NULL,
	[Email]			varchar(50)		NOT NULL,
	[Password]		nvarchar(50)		NOT NULL,
	[IdUserTypes]	int			FOREIGN KEY REFERENCES [UserTypes]([Id])
									ON DELETE NO ACTION
									ON UPDATE CASCADE,
	[IdLibrary]		int			FOREIGN KEY REFERENCES [Library](Id)
									ON DELETE NO ACTION
									ON UPDATE CASCADE,
	[IdDirector]	int				NULL,
	FOREIGN KEY ([IdDirector]) REFERENCES [User]([Id])
)
GO

CREATE TABLE [UserLibrary]
(
	[Id]		int		PRIMARY KEY NOT NULL,
	[IdUser]	int		FOREIGN KEY REFERENCES [User]([Id])
									ON DELETE NO ACTION
									ON UPDATE NO ACTION,
	[IdLibrary]	int		FOREIGN KEY REFERENCES [Library]([Id])
									ON DELETE NO ACTION
									ON UPDATE NO ACTION,
)
GO

CREATE TABLE [Book]
(
	[Id]				int				PRIMARY KEY NOT NULL,
	[Name]				varchar(100)	NOT NULL,
	[PublishedYear]		date			NOT NULL,
	[Redaction]			varchar(100)	NOT NULL,
	[Pages]				int				NOT NULL,
	[Summary]			varchar(max)	NOT NULL,
	[Author]			varchar(50)		NOT NULL,
	[Location]			varchar(100)	NOT NULL,
	[IsAvailable]		bit				NOT NULL
)
GO

CREATE TABLE [Order]
(
	[Id]		int		PRIMARY KEY NOT NULL,
	[TakeDay]	date	NOT NULL,
	[BackDay]	date	NULL,
	[IdBook]	int		FOREIGN KEY REFERENCES [Book]([Id])
									ON DELETE NO ACTION
									ON UPDATE CASCADE,
	[IdUser]	int		FOREIGN KEY REFERENCES [User]([Id])
									ON DELETE NO ACTION
									ON UPDATE CASCADE,
)
GO

CREATE TABLE [Formular]
(
	[Id]		int				PRIMARY KEY NOT NULL,
	[IdUser]	int				FOREIGN KEY REFERENCES [User]([Id])
											ON DELETE CASCADE
											ON UPDATE CASCADE
)
GO