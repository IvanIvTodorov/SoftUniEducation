CREATE TABLE Teachers
(
	TeacherID INT PRIMARY KEY IDENTITY (101,1),
	[Name] NVARCHAR(10) NOT NULL,
	ManagerID INT REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers ([Name] , ManagerID)
VALUES
('Jhon', null),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101)