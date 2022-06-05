SELECT T.DepartmentID, T.Salary AS ThirdHighestSalary
FROM
(SELECT DepartmentId, Salary,
DENSE_RANK() OVER (PARTITION BY DepartmentId ORDER BY Salary DESC) as Rank
FROM Employees
GROUP BY DepartmentID,Salary) AS T
WHERE T.Rank = 3

