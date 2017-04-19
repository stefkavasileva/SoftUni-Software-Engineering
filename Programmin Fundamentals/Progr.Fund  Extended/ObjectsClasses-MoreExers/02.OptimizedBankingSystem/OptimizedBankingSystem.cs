using System;
using System.Collections.Generic;
using System.Linq;

public class OptimizedBankingSystem
{
    static void Main()
    {
        var inputLine = Console.ReadLine();

        var accounts = new List<BankAccount>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine
                .Split("| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var bank = tokens[0];
            var accountName = tokens[1];
            var accountBalance = decimal.Parse(tokens[2]);

            if (!accounts.Any(x => x.Name == accountName && x.Bank == bank))
            {
                var newAccount = new BankAccount
                {
                    Bank = bank,
                    Name = accountName,
                    Balance = accountBalance
                };

                accounts.Add(newAccount);
            }
            else
            {
                accounts.Where(a => a.Bank == bank).First().Balance += accountBalance;
            }

            inputLine = Console.ReadLine();
        }

        accounts = accounts
            .OrderByDescending(x => x.Balance)
            .ThenBy(x => x.Bank.Length)
            .ToList();

        foreach (var account in accounts)
        {
            Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
        }
    }
}

