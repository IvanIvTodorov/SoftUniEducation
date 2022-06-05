SELECT TOP(10) E.FirstName, E.LastName, E.DepartmentID
FROM Employees AS E
JOIN (SELECT DepartmentID, AVG(Salary) AS AVG
FROM Employees 
GROUP BY DepartmentID) AS T ON E.DepartmentID = T.DepartmentID
WHERE Salary > T.AVG
ORDER BY DepartmentID



