SELECT TOP(5) EmployeeID,FirstName,Salary,D.Name
  FROM Employees AS E 
INNER JOIN Departments AS D ON E.DepartmentID=D.DepartmentID
WHERE E.Salary>15000
ORDER BY D.DepartmentID