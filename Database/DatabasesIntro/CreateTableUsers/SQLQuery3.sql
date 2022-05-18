CREATE TABLE USERS
(
	Id BIGINT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARCHAR(MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT
)

INSERT INTO Users (Username, [Password], ProfilePicture,LastLoginTime,IsDeleted)
VALUES 
('batvan', '123', 'https://gradcontent.com/avatars/thumb/p_20151201_082407_35106.jpg', '1/1/2021', 1),
('batpen', '1233', 'https://gradcontent.com/avatars/thumb/p_20151201_082407_35106.jpg', '1/22/2021', 1),
('bat124van', '142123', 'https://gradcontent.com/avatars/thumb/p_20151201_082407_35106.jpg', '1/15/2021', 1),
('bat124van', '124213', 'https://gradcontent.com/avatars/thumb/p_20151201_082407_35106.jpg', '1/1/2021', 1),
('bat1241van', '1412423', 'https://gradcontent.com/avatars/thumb/p_20151201_082407_35106.jpg', '1/19/2021', 1)