CREATE PROC usp_GetHoldersWithBalanceHigherThan(@number DECIMAL(13,2)) AS 
SELECT FirstName,LastName
  FROM AccountHolders AS ah
  JOIN Accounts AS a ON ah.Id=a.AccountHolderId
 GROUP BY FirstName,LastName
 HAVING SUM (a.Balance) > @number

 EXEC dbo.usp_GetHoldersWithBalanceHigherThan 200