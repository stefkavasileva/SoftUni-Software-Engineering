using System;

public class SquareFrame
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            if (row == 1 || row == n)
            {
                Console.Write("+");
                for (int col = 0; col < ((2 * n) - 3); col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.Write("+");
            }
            else
            {
                Console.Write("|");
                for (int col = 0; col < ((2 * n) - 3); col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.Write("|");
            }

            Console.WriteLine();
        }
    }
}
