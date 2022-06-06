CREATE PROC usp_CalculateFutureValueForAccount 
@AccId INT, 
@Percent DECIMAL(18,4)
AS
	SELECT TOP(1) A.Id AS [Account Id], 
	A.FirstName AS [First Name], 
	A.LastName AS [Last Name], 
	AC.Balance [Current Balance], 
	dbo.ufn_CalculateFutureValue(ac.Balance, @Percent, 5) AS [Balance in 5 years]
	FROM AccountHolders A
	INNER JOIN Accounts AC ON A.Id = AC.AccountHolderId
	WHERE A.Id = @AccId
GO

EXEC usp_CalculateFutureValueForAccount 1, 0.1
