SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, d.[Name]
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE E.Salary > 15000
ORDER BY d.DepartmentID