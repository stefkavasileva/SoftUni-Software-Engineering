using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();

        var inputLine = Console.ReadLine();
        while (inputLine != "End")
        {
            var tokens = inputLine
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var currentComandName = tokens[0];
            if (currentComandName.Equals("Create"))
            {
                CreateAccount(int.Parse(tokens[1]), accounts);
            }
            else if (currentComandName.Equals("Deposit"))
            {
                Deposit(tokens, accounts);
            }
            else if (currentComandName.Equals("Withdraw"))
            {
                Withdraw(tokens, accounts);
            }
            else if (currentComandName.Equals("Print"))
            {
                Print(int.Parse(tokens[1]), accounts);
            }

            inputLine = Console.ReadLine();
        }
    }

    private static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!IsAccountExist(accounts, id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        Console.WriteLine(accounts[id]);
    }

    private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        if (!IsAccountExist(accounts, int.Parse(tokens[1])))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var currentAccount = accounts[int.Parse(tokens[1])];
        var amount = double.Parse(tokens[2]);

        if (currentAccount.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        currentAccount.Balance -= amount;
    }

    private static void Deposit(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        if (!IsAccountExist(accounts, int.Parse(tokens[1])))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var deposit = double.Parse(tokens[2]);
        var id = int.Parse(tokens[1]);
        accounts[id].Balance += deposit;
    }

    private static bool IsAccountExist(Dictionary<int, BankAccount> accounts, int id)
    {
        return accounts.ContainsKey(id);
    }

    private static void CreateAccount(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(accountId))
        {
            var account = new BankAccount();
            account.ID = accountId;
            accounts.Add(accountId, account);
            return;
        }

        Console.WriteLine($"Account already exists");
    }
}

