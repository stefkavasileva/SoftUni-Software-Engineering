SELECT TOP(5) C.CountryName,R.RiverName
  FROM Countries AS C
LEFT OUTER JOIN CountriesRivers AS CR ON C.CountryCode = CR.CountryCode
LEFT OUTER JOIN Rivers AS R ON CR.RiverId = R.Id
WHERE C.ContinentCode ='AF'
ORDER BY C.CountryName