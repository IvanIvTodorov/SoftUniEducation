CREATE PROC usp_EmployeesBySalaryLevel @Param NVARCHAR(MAX)
AS
	SELECT FirstName, LastName
	FROM Employees 
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @Param
GO
EXEC usp_EmployeesBySalaryLevel 'High'