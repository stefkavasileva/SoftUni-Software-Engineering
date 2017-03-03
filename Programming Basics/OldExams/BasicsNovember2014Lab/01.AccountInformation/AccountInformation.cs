using System;

public class AccountInformation
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int clientId = int.Parse(Console.ReadLine());
        decimal acountBalance = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}");
        Console.WriteLine($"Client id: {clientId}");
        Console.WriteLine($"Total balance: {acountBalance:f2}");
        Console.WriteLine("Active: {0}", acountBalance >= 0 ? "yes" : "no");
    }
}