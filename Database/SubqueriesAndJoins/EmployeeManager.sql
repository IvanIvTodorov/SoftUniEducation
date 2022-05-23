SELECT e.EmployeeID, e.FirstName, e.ManagerID, e2.FirstName
FROM Employees e 
JOIN Employees e2 ON e.ManagerID = e2.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID