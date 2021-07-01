USE [Library]
GO

DELETE FROM [Filial];
INSERT INTO [Filial] ([Id], [Name], [Phone], [Address]) 
VALUES	(1, 'Alphabet', '+80662738456', 'Kapuchino str')
GO

DELETE FROM [Library];
INSERT INTO [Library] ([Id], [Name], [Phone], [Address], [IdFilial]) 
VALUES	(1, 'Central', '+80224563456', 'Glinki str', 1),
		(2, 'Left', '+80445634256', 'Krutaya str', 1)
GO

DELETE FROM [UserTypes];
INSERT INTO [UserTypes] ([Id], [Type]) 
VALUES	(1, 'Librarian'),
		(2, 'Security'),
		(3, 'User'),
		(4, 'Director')
GO

DELETE FROM [Book];
INSERT INTO [Book] ([Id], [Name], [PublishedYear], [Author], [Pages], [Redaction], [Summary], [Location], [IsAvailable]) 
VALUES	(1, 'The Clean Code', '05/04/2011', 'Robert Martin', 500, 'Prentice Hall', 'The Clean Coder, he shares his experience to explain what is his vision of professionalism when working as a software developer', 'A1', 1),
		(2, 'The Passionate Programmer', '05/28/2009', 'Ched Fauler', 250, 'Pragmatic Life', 'You will learn how to build your software development career step by step, following the same path that you would follow if you were building, marketing, and selling a product', 'B1', 1),
		(3, 'Design Patterns', '10/21/1994', 'Erih Gamma', 395, 'Addison-Wesley', 'In software engineering, a software design pattern is a general, reusable solution to a commonly occurring problem within a given context in software design', 'A1', 1)
GO

DELETE FROM [User];
INSERT INTO [User] ([Id], [Name], [SurName], [INN], [Address], [Birthday], [Phone], [IdDirector], [IdLibrary], [IdUserTypes]) 
VALUES	(1, 'Ivan', 'Ivashchenko', 324567546, 'Zap highway', '03/05/1994', '+80662345689', NULL, 1, 3),
		(2, 'Jack', 'Ivanov', 498578604, 'Lenina str', '11/02/2000', '+80449876356', NULL, 1, 3),
		(3, 'Alex', 'Samoilov', 356787612, 'Kirova str', '01/01/1993', '+80778937643', NULL, 1, 3),
		(4, 'Leonid', 'Lishrack', 666574568, 'Main highway', '04/11/1998', '+80664563678', NULL, 1, 3),
		(5, 'Anton', 'Trofimov', 352345645, 'Raduga str', '10/16/1984', '+80445672345', NULL, 1, 4),
		(6, 'Elena', 'Orhipova', 234123456, 'Lesnaya str', '12/31/1989', '+80567800034', 5, 1, 1),
		(7, 'Mary', 'Timofeeva', 334564357, 'Luk str', '12/12/1991', '+80334563456', 5, 2, 1)
GO

DELETE FROM [Order];
INSERT INTO [Order] ([Id], [TakeDay], [BackDay], [IdBook], [IdUser]) 
VALUES	(1, '01/01/2010', '01/08/2010', 1, 1),
		(2, '02/14/2013', '02/22/2013', 2, 3),
		(3, '02/01/2011', '02/24/2011', 1, 2),
		(4, '03/03/2014', '03/08/2014', 3, 1),
		(5, '11/03/2020', '12/08/2020', 3, 2),
		(6, '04/01/2014', '04/08/2014', 2, 3),
		(7, '01/01/2015', '05/06/2015', 1, 4)
GO

DELETE FROM [Formular];
INSERT INTO [Formular] ([Id], [IdUser]) 
VALUES	(1, 1),
		(2, 2),
		(3, 3),
		(4, 4)
GO

DELETE FROM [UserLibrary];
INSERT INTO [UserLibrary] ([Id], [IdUser], [IdLibrary]) 
VALUES	(1, 1, 1),
		(2, 2, 1),
		(3, 3, 1),
		(4, 4, 1),
		(5, 5, 1),
		(6, 6, 1),
		(7, 7, 2)
GO