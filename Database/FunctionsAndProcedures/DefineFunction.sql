CREATE FUNCTION ufn_IsWordComprised(@Letters NVARCHAR(MAX), @Word NVARCHAR(MAX))
RETURNS BIT
BEGIN
	DECLARE @I INT = 1;
		WHILE (@I <= LEN(@Word))
			BEGIN
				IF (CHARINDEX(SUBSTRING(@Word, @I, 1), @Letters) = 0)
					BEGIN 
						RETURN 0;
					END
				SET @I += 1;
			END
	RETURN 1
END
