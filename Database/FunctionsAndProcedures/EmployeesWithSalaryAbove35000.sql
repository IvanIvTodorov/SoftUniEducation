CREATE OR ALTER PROC usp_GetEmployeesSalaryAbove35000
AS
	SELECT FirstName as [First Name], LastName as [Last Name]
	FROM Employees
	WHERE Salary > 35000
GO;
EXEC usp_GetEmployeesSalaryAbove35000;