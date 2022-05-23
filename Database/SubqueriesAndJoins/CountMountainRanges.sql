SELECT c.CountryCode, COUNT(mc.CountryCode) AS MountainRanges
FROM Countries c  
INNER JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
INNER JOIN Mountains m ON mc.MountainId = m.Id
WHERE c.CountryCode IN ('BG','RU', 'US')
GROUP BY c.CountryCode, mc.CountryCode


