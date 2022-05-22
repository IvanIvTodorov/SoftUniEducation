SELECT * FROM (
SELECT EmployeeID, FirstName, LastName, Salary,
RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 and 50000 ) t
WHERE [Rank] = 2
ORDER BY Salary DESC