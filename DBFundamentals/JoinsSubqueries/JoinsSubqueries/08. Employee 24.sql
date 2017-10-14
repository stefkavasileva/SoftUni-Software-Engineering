SELECT E.EmployeeID,FirstName,
  CASE 
   WHEN P.StartDate > '01/01/2005' THEN NULL
   ELSE P.NAME
  END 
  FROM Employees AS E
INNER JOIN EmployeesProjects AS EP ON EP.EmployeeID = E.EmployeeID
INNER JOIN Projects AS P ON EP.ProjectID = P.ProjectID
WHERE E.EmployeeID = 24
