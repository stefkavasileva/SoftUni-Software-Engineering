CREATE PROC usp_GetHoldersFullName AS
SELECT FirstName + ' ' + LastName AS [Full Name] 
  FROM AccountHolders

EXEC usp_GetHoldersFullName 