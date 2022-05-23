SELECT TOP(3) e.EmployeeID, e.FirstName
FROM Employees e
LEFT JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
LEFT JOIN Projects p ON ep.ProjectID = p.ProjectID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID