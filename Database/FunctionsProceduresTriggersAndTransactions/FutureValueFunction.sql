CREATE FUNCTION ufn_CalculateFutureValue (@Sum Decimal(18,4), @Year FLOAT, @NumYears INT)
RETURNS DECIMAL (18,4)
AS
BEGIN
	DECLARE @res DECIMAL(18,4)

	SET @res = @Sum * (POWER((1 + @Year),@NumYears))

	RETURN @res
END;

SELECT dbo.ufn_CalculateFutureValue (1000, 0.1, 5)