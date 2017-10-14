SELECT TOP(5) E.EmployeeID,FirstName,P.Name
  FROM Employees AS E 
INNER JOIN EmployeesProjects AS EP ON EP.EmployeeID = E.EmployeeID
INNER JOIN Projects AS P ON P.ProjectID = EP.ProjectID
WHERE P.StartDate > '08/13/2002' AND P.EndDate IS NULL
ORDER BY E.EmployeeID