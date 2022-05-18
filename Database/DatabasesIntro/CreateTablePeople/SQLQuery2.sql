CREATE TABLE People
(
	Id INT IDENTITY primary key,
	[Name] NVARCHAR(200) NOT NULL,
	Picture NVARCHAR(MAX) NULL,
	Height decimal(15,2) null,
	[Weight] decimal(15,2) null,
	Gender bit not null,
	Birthdate date not null,
	Biography nvarchar(max) not null
)

insert into People ([Name], Picture, Height,[Weight], Gender, Birthdate, Biography)
values
('ivan', 'somsasdepic', 122.3, 12.3, 0, '1/1/2022', 'absdasdasd'),
('ifsavan', 'sofmepic', 123.3, 12312.3, 0, '1/2/2022', 'absdfaasd'),
('idvan', 'sodmepic', 1242.3, 11232.3, 0, '1/3/2022', 'absdassfad'),
('ivfan', 'sosmepic', 11232.3, 12213.3, 0, '1/4/2022', 'absasddasd'),
('ivfaczn', 'sosmeweqpic', 11232.3, 12243.3, 0, '1/5/2022', 'absasddasd')