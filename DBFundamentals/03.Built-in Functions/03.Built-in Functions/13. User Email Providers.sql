SELECT Username, SUBSTRING(Email,CHARINDEX('@',Email)+1, LEN(Email)) AS[Email Provider] 
  FROM Users
 ORDER BY [Email Provider],Username
