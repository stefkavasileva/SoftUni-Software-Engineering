SELECT DepartmentID, MAX(Salary) AS [MaxSalary]  
  FROM Employees
 GROUP BY DepartmentID
 HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000;