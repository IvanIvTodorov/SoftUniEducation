SELECT TOP(5) T.Country,
CASE
	WHEN T.[Highest Peak Name] IS NULL THEN '(no highest peak)'
	ELSE T.[Highest Peak Name]
	END AS [Highest Peak Name],
CASE
	WHEN T.[Highest Peak Elevation] IS NULL THEN 0
	ELSE T.[Highest Peak Elevation]
	END AS [Highest Peak Elevation],
CASE
	WHEN T.Mountain IS NULL THEN '(no mountain)'
	ELSE T.Mountain
	END AS Mountain 
FROM
(SELECT c.CountryName AS Country, p.PeakName AS [Highest Peak Name], p.Elevation AS [Highest Peak Elevation], m.MountainRange AS Mountain,
RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS RANK
FROM Countries c
LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains m ON MC.MountainId = M.Id
LEFT JOIN Peaks p ON m.id = p.MountainId) AS T
WHERE T.RANK = 1 
ORDER BY T.Country, T.[Highest Peak Name]
