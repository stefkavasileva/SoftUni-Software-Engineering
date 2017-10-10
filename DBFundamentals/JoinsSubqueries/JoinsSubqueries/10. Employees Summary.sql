SELECT TOP(50) E.EmployeeID, CONCAT(E.FirstName,' ',E.LastName) AS [EmployeeName], CONCAT (M.FirstName, ' ',M.LastName) AS [ManagerName], D.Name
  FROM Employees AS E
INNER JOIN Employees AS M ON E.ManagerID = M.EmployeeID
JOIN Departments AS D ON D.DepartmentID = E.DepartmentID
ORDER BY E.EmployeeID