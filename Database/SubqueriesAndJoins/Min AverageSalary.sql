SELECT TOP(1) AVG(Salary) AS MinAverageSalaary
FROM Employees
GROUP BY DepartmentID
ORDER BY AVG(Salary)