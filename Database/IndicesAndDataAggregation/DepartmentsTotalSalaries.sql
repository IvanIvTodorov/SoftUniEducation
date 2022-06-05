SELECT DepartmentID, SUM(SALARY)
FROM Employees
GROUP BY DepartmentID