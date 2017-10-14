SELECT mc.CountryCode ,m.MountainRange, p.PeakName, p.Elevation
FROM Mountains AS m
INNER JOIN Peaks AS p ON m.Id = p.MountainId
INNER JOIN MountainsCountries AS mc ON m.Id = mc.MountainId
WHERE p.Elevation > 2835
AND mc.CountryCode = 'BG'
ORDER BY Elevation DESC