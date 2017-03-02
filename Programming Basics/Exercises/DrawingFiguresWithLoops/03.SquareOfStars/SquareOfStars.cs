using System;

public class SquareOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < (2 * n) - 1; col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}