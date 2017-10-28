SELECT FirstName 
  FROM Employees
 WHERE DepartmentID IN (3,10) 
       AND (SELECT YEAR(HireDate))>= 1995 
	   AND (SELECT YEAR(HireDate)) <= 2005