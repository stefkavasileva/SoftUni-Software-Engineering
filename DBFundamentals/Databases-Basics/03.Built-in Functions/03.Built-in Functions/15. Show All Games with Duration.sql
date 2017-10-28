SELECT Name, 
	'Part of the day' =
	CASE 
		WHEN DATEPART(HOUR, Start) >= 0 AND DATEPART(hour, Start) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, Start) >= 12 AND DATEPART(hour, Start) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END,
	Duration =
	CASE 
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration > 3 AND Duration <= 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		ELSE 'Extra Long'
	END
FROM Games
ORDER BY Name, Duration, [Part of the day]