SELECT t.ContinentCode, t.CurrencyCode, t.CurrencyUsage
FROM
(SELECT c.ContinentCode, c.CurrencyCode, COUNT(c.CurrencyCode) AS CurrencyUsage,
RANK() OVER (PARTITION BY c.ContinentCode ORDER BY COUNT(c.CurrencyCode) DESC) AS RANKED
FROM Countries c 
GROUP BY c.ContinentCode, c.CurrencyCode) AS t
WHERE t.RANKED = 1 AND t.CurrencyUsage !=1
ORDER BY t.ContinentCode