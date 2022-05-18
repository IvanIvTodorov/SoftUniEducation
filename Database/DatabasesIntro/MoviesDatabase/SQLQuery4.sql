CREATE TABLE Categories   
(
	Id int primary key,
	CategoryName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(26) not NULL,
)

CREATE TABLE Directors   
(
	Id int primary key,
	DircetorName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(26) not NULL,
)

CREATE TABLE Genres   
(
	Id int primary key,
	GenreName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(26) not NULL,
)

CREATE TABLE Movies    
(
	Id int primary key,
	Title nvarchar(20) not null,
	DirectorId int not null,
	CopyrightYear date not null,
	[Length] int null,
	GenreId int not null,
	CategoryId int not null,
	Rating tinyint null,
	Notes NVARCHAR(26) NULL,
)

Insert into Categories(Id, CategoryName,Notes)
values
(1,'ivan', 'blahbkla'),
(2,'ivadsan', 'blaasdhbkla'),
(3,'idsavan', 'blaasdhbkla'),
(4,'ivsdaan', 'asd'),
(5,'ivsdasdaan', 'asd')


Insert into Directors(Id,DircetorName,Notes)
values
(1,'ivan', 'blahbkla'),
(2,'ivadsan', 'blaasdhbkla'),
(3,'idsavan', 'blaasdhbkla'),
(4,'idsavsdaan', 'adsasd'),
(5,'ivsdasdaan', 'adsasd')


Insert into Genres(Id,GenreName, Notes)
values
(1,'ivan', 'blahbkla'),
(2,'ivadsan', 'blaasdhbkla'),
(3,'idsavan', 'blaasdhbkla'),
(4,'ivs213daan', 'asd'),
(5,'iv321sdaan', 'asd')


insert into Movies (Id,Title,DirectorId,CopyrightYear, [Length] ,GenreId, CategoryId,Rating,Notes)
Values
(1,'ivfacdsadszn', 1, '1/6/2022', 20, 1, 2, 10 , 'sofmedsatext'),
(2,'ivfacdsadszn', 2, '2/6/2022', 0, 1, 1, 10 , 'sofmetsdaext'),
(3,'ivfacdsadszn', 3, '3/6/2022', 220, 3, 3, 10 , 'sofmsadetext'),
(4,'ivfacdsadszn', 4, '4/6/2022', 24, 3, 3, 10 , 'sofmedsatext'),
(5,'ivfacdsadszn', 1, '5/6/2022', 25, 4, 2, 10 , 'sofdsametext')