CREATE PROC usp_GetEmployeesSalaryAboveNumber (@Param DECIMAL(18,4))
AS
	SELECT FirstName as [First Name], LastName as [Last Name]
	FROM Employees
	WHERE Salary >= @Param
GO

EXEC usp_GetEmployeesSalaryAboveNumber 35000