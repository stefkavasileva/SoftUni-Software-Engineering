CREATE TABLE Logs
(
  LogID INT NOT NULL IDENTITY,
  AccountID INT FOREIGN KEY REFERENCES Accounts(Id),
  OldSum MONEY,
  NewSum MONEY,
)

CREATE TRIGGER tr_ChangeBalance ON Accounts
AFTER UPDATE
AS
BEGIN
INSERT INTO Logs(AccountID,OldSum,NewSum)
SELECT i.Id, d.Balance, i.Balance 
FROM inserted AS i
INNER JOIN deleted AS d
ON i.Id = d.Id
END
