SELECT Username, RIGHT(Email, LEN(EMAIL) - CHARINDEX('@', Email, 0)) AS [Email Provider]
FROM Users
ORDER BY [Email provider], Username