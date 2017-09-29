CREATE TABLE People
(
Id int PRIMARY KEY IDENTITY,
Name varchar(50),
Birthdate datetime
)

INSERT INTO People(Name, Birthdate)
VALUES
('PESHO', '1985-01-03')

SELECT 
Name, 
DATEDIFF(year, Birthdate, GETDATE()) AS [Age in Years],
DATEDIFF(month, Birthdate, GETDATE()) AS [Age in Months],
DATEDIFF(day, Birthdate, GETDATE()) AS [Age in Days],
DATEDIFF(minute, Birthdate, GETDATE()) AS [Age in Minutes]
FROM People