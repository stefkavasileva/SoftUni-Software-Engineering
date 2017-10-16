SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
  FROM WizzardDeposits
 WHERE MagicWandCreator ='Ollivander family'
 GROUP BY DepositGroup
 HAVING SUM(DepositAmount) < 150000
 ORDER BY TotalSum DESC  