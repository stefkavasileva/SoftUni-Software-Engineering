SELECT * 
  FROM Towns
 WHERE NOT LEFT(Name,1) IN ('R','D','B')
 ORDER BY Name
