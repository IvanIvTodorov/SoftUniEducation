SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM Countries c
INNER JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
INNER JOIN Mountains m ON mc.MountainId = m.Id
INNER JOIN Peaks p ON m.Id = p.MountainId
WHERE p.Elevation > 2835 AND c.CountryCode = 'BG'
ORDER BY p.Elevation DESC