SELECT MC.CountryCode, COUNT(MC.CountryCode)
  FROM MountainsCountries AS MC
JOIN Mountains AS M ON M.ID = MC.MountainId
WHERE MC.CountryCode IN ('US','BG','RU')
GROUP BY MC.CountryCode
