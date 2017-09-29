SELECT TOP 50 Name, FORMAT(Start,'yyyy-MM-dd') AS [Start Date] 
  FROM Games
 WHERE (SELECT YEAR(Start)) IN (2011,2012)
 ORDER BY [Start Date], Name 

 