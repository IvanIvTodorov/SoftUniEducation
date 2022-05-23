 SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name]
 FROM Employees e
 JOIN Departments d ON e.DepartmentID = d.DepartmentID
 WHERE d.[Name] = 'Sales'
 ORDER BY e.EmployeeID