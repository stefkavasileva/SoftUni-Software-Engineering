using System;

public class TriangleOfDollars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("$ ");
            }

            Console.WriteLine();
        }
    }
}