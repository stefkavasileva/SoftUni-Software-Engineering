using System;

public class NumFrom1ToN
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
