using System;

public class StripedTowel
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string elements = "#..";
        int count = 0;

        for (int i = 1; i <= 1.5 * n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (count > elements.Length - 1)
                {
                    count = 0;
                }

                char symbol = elements[count];
                count++;

                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
