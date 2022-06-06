CREATE PROC usp_GetHoldersWithBalanceHigherThan  (@Param DECIMAL(18,4))
AS	
	SELECT T.FirstName, T.LastName
	FROM (
	SELECT AH.FirstName, AH.LastName, SUM(A.Balance) AS Bal
	FROM AccountHolders AH
	INNER JOIN Accounts A ON AH.Id = A.AccountHolderId	
	GROUP BY A.AccountHolderId, AH.FirstName, AH.LastName ) AS T
	WHERE t.Bal > @Param
	ORDER BY T.FirstName, T.LastName
GO

