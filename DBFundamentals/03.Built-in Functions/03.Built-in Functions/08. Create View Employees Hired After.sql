CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName,LastName 
  FROM Employees
 WHERE (SELECT YEAR(HireDate)) > 2000