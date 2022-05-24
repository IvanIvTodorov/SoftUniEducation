SELECT COUNT(*) AS Count
FROM Countries c
LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL
GROUP BY mc.MountainId

