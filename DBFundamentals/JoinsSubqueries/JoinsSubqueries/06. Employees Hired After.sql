SELECT FirstName,LastName,HireDate,D.Name 
  FROM Employees AS E 
INNER JOIN Departments AS D ON D.DepartmentID=E.DepartmentID
WHERE E.HireDate > '1.1.1999' AND D.Name IN ('Sales','Finance')
ORDER BY HireDate