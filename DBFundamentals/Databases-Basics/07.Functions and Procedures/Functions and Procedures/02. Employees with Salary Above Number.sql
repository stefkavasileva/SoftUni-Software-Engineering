CREATE PROC usp_GetEmployeesSalaryAboveNumber (@Value DECIMAL(18,4))
         AS
	 SELECT FirstName,LastName 
	   FROM Employees 
	  WHERE  Salary >= @Value

EXEC dbo.usp_GetEmployeesSalaryAboveNumber 48100;