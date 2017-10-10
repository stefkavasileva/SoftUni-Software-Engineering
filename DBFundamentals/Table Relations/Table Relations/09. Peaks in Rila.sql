SELECT (SELECT MountainRange FROM Mountains WHERE MountainRange = 'Rila') AS [MountainRange] ,PeakName, Elevation FROM Peaks
WHERE MountainId = (SELECT Id FROM Mountains WHERE MountainRange = 'Rila')
ORDER BY Elevation DESC

SELECT MountainRange, PeakName, Elevation
FROM Mountains
JOIN Peaks ON Mountains.Id = Peaks.MountainId
WHERE MountainRange = 'Rila'
ORDER BY Elevation DESC