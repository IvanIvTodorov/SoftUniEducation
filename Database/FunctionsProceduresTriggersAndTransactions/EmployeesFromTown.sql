CREATE PROC usp_GetEmployeesFromTown @Param NVARCHAR(MAX)
AS
	SELECT E.FirstName, E.LastName
	FROM Towns T
	INNER JOIN Addresses A ON T.TownID = A.TownID
	INNER JOIN Employees E ON  A.AddressID = E.AddressID
	WHERE T.[Name] LIKE @Param + '%';
GO
EXEC usp_GetEmployeesFromTown 'B';