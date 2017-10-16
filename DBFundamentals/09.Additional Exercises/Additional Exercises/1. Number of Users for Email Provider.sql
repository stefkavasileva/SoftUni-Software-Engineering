CREATE PROC usp_UsersProviders
AS
SELECT RIGHT(Email,LEN(Email) - CHARINDEX('@',Email)) AS [Providers] 
FROM Users 
GROUP BY usp_UsersProviders
