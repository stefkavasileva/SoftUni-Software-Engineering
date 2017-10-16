CREATE PROC usp_GetEmployeesSalaryAbove35000 
         AS
     SELECT FirstName,LastName 
	   FROM Employees
      WHERE Salary > 35000

EXEC dbo.usp_GetEmployeesSalaryAbove35000