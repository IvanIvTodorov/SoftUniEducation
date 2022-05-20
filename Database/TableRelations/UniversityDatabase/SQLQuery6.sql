CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY,
	[Name] NVARCHAR(10) NOT NULL
);

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY,
	StudentNumber INT NOT NULL,
	StudentName NVARCHAR(10) NOT NULL,
	MajorID INT REFERENCES Majors(MajorID)
);

CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY,
	PaymentDate DATE NOT NULL,
	PaymentAmount DECIMAL(8,2),
	StudentID INT REFERENCES Students(StudentID)
);

CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY,
	SubjectName NVARCHAR(10) NOT NULL,
);

CREATE TABLE Agenda
(
	StudentID INT REFERENCES Students(StudentID),
	SubjectID INT REFERENCES Subjects(SubjectID),
	PRIMARY KEY(StudentID, SubjectID)
);