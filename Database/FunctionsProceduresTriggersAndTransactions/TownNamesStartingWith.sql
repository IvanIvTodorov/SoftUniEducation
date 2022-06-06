CREATE PROC usp_GetTownsStartingWith @Param NVARCHAR(MAX)
AS
	SELECT [Name] AS Town
	FROM Towns
	WHERE [Name] LIKE @Param + '%'
GO
EXEC usp_GetTownsStartingWith b
