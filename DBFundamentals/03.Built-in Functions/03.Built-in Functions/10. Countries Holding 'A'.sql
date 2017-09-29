SELECT CountryName AS [Country Name], IsoCode AS [Iso Code] 
  FROM Countries
 WHERE LEN(CountryName) - LEN(REPLACE(CountryName,'a','')) >=3
 ORDER BY [Iso Code]