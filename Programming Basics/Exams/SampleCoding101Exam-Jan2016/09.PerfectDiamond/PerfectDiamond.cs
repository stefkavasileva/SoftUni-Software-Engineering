using System;

public class PerfectDiamond
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int spaces = n - 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}*", new string(' ', spaces));
            for (int j = 0; j < i; j++)
            {
                Console.Write("-*");
            }

            Console.WriteLine();
            spaces--;
        }

        spaces = 1;

        for (int i = n - 2; i >= 0; i--)
        {
            Console.Write("{0}*", new string(' ', spaces));
            for (int j = i; j > 0; j--)
            {
                Console.Write("-*");
            }

            Console.WriteLine();
            spaces++;
        }
    }
}
