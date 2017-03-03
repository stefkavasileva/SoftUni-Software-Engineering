using System;

public class NewHouse
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dashes = n / 2;
        int asterisks = 1;

        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', dashes),
                new string('*', asterisks));

            dashes--;
            asterisks += 2;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|",
                new string('*', n - 2));
        }
    }
}