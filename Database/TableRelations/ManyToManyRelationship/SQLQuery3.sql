CREATE TABLE Students 
(
	StudentID INT PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(20) NOT NULL
);

CREATE TABLE Exams 
(
	ExamID INT PRIMARY KEY IDENTITY(101,1), 
	[Name] NVARCHAR(20) NOT NULL
);

INSERT INTO Students([Name])
VALUES
('Mila'),
('Toni'),
('Ron');

INSERT INTO Exams([Name])
VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g');

CREATE TABLE StudentsExams
(
	StudentID INT REFERENCES Students(StudentID),
	ExamID INT REFERENCES Exams(ExamID),
	PRIMARY KEY(StudentID, ExamID)
);