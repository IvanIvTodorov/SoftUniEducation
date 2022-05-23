SELECT TOP(50)
	e.EmployeeID, 
	CONCAT(e.FirstName, ' ',e.LastName) as EmployeeName, 
	CONCAT(e2.FirstName, ' ', e2.LastName) as ManagerName,
	d.[Name] as DepartmentName
FROM Employees e
JOIN Employees e2 ON e.ManagerID = e2.EmployeeID
JOIN Departments d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID
