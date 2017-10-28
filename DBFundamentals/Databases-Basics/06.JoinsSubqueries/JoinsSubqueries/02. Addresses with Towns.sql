SELECT TOP(50) FirstName,LastName,T.Name,AddressText
  FROM Employees AS E
INNER JOIN Addresses AS A ON A.AddressID = E.AddressID
INNER JOIN Towns AS T ON T.TownID = A.TownID
ORDER BY FirstName,LastName