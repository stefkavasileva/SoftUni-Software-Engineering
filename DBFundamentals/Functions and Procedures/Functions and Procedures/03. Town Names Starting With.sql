CREATE OR ALTER PROC usp_GetTownsStartingWith(@Text VARCHAR(50)) 
         AS
	 SELECT Name
	   FROM Towns 
	  WHERE LEFT(Name,LEN(@Text)) = @Text

EXEC dbo.usp_GetTownsStartingWith 'BELL'