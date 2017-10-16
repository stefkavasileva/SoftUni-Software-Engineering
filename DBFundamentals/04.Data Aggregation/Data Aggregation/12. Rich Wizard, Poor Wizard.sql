SELECT SUM(ResultTable.[Difference]) AS SumDifference
FROM (SELECT DepositAmount - (SELECT DepositAmount FROM WizzardDeposits WHERE Id = WizDeposits.Id + 1) 
AS [Difference] FROM WizzardDeposits WizDeposits) AS ResultTable