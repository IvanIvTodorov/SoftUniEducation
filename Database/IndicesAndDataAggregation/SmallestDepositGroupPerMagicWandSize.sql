SELECT T.DepositGroup
FROM 
(SELECT 
	DepositGroup, 
	AVG(MagicWandSize) as Temp,
	RANK() OVER (ORDER BY DepositGroup) as Rank
	FROM WizzardDeposits
	GROUP BY DepositGroup) AS T
WHERE T.Rank IN (3,4)