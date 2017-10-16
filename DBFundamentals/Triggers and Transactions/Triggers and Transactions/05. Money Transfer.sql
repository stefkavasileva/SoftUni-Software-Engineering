CREATE PROC usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount MONEY)
AS
BEGIN TRANSACTION
EXEC usp_DepositMoney @ReceiverId, @Amount
EXEC usp_WithdrawMoney @SenderId, @Amount
COMMIT
 