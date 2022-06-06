CREATE OR ALTER FUNCTION ufn_GetSalaryLevel
(
	@Param DECIMAL(18,4)
)
RETURNS NVARCHAR(MAX)
AS BEGIN
	DECLARE @result NVARCHAR(MAX);
		IF (@Param < 30000)
			SET @result = 'Low';
		ELSE IF (@Param < 50000)
			SET @result = 'Average';
		ELSE 
			SET @result = 'High';
	Return @result
END

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level]
FROM Employees
