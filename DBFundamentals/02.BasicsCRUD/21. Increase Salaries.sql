UPDATE Employees
   SET Salary += Salary * 0.12
 WHERE DepartmentID IN(1,2,4,11)

SELECT Salary 
  FROM Employees