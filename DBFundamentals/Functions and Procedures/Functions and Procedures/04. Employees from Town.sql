CREATE PROC usp_GetEmployeesFromTown(@TownName VARCHAR(50))
         AS
     SELECT FirstName AS [First Name], LastName AS [Last Name]
	   FROM Employees AS e
       JOIN Addresses AS a ON e.AddressID = a.AddressID
       JOIN Towns AS t ON t.TownID = a.TownID
      WHERE t.Name = @TownName

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'
