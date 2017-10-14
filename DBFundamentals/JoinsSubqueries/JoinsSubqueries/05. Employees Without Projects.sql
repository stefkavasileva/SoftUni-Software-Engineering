SELECT TOP(3) E.EmployeeID,FirstName
  FROM Employees AS E
LEFT OUTER JOIN EmployeesProjects AS EP ON EP.EmployeeID=E.EmployeeID
WHERE EP.ProjectID IS NULL
ORDER BY EmployeeID
