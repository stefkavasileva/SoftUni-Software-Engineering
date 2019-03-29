using System;
using System.Collections.Generic;
using System.Linq;

public class OrderedBankingSystem
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var banks = new Dictionary<string, Dictionary<string, decimal>>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            var bank = tokens[0];
            var account = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            if (!banks.ContainsKey(bank))
            {
                banks.Add(bank, new Dictionary<string, decimal>());
            }

            if (!banks[bank].ContainsKey(account))
            {
                banks[bank].Add(account, balance);
            }
            else
            {
                banks[bank][account] += balance;
            }



            inputLine = Console.ReadLine();
        }

        banks = banks
            .OrderByDescending(x => x.Value.Values.Sum())
            .ThenByDescending(x => x.Value.Values.Max(y => y))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in banks)
        {
            foreach (var innerKvp in kvp.Value.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{innerKvp.Key} -> {innerKvp.Value} ({kvp.Key})");
            }
        }
    }
}

