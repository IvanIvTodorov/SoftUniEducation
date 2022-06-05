SELECT 
DepartmentID,
EmployeeID,
ManagerID,
Salary
INTO EmployeeWithSalaryOver30000
FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeeWithSalaryOver30000
WHERE ManagerID = 42

UPDATE EmployeeWithSalaryOver30000
SET Salary = Salary + 5000
WHERE DepartmentID = 1

SELECT 
DepartmentID,
AVG(Salary) AS AverageSalary
FROM EmployeeWithSalaryOver30000
GROUP BY DepartmentID