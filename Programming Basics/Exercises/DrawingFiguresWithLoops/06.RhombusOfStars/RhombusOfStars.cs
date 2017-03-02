using System;

public class RhombusOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int blanks = n - 1;

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', blanks));
            for (int col = 0; col < row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            blanks--;
        }

        blanks = 1;

        for (int row = n - 1; row >= 1; row--)
        {
            Console.Write(new string(' ', blanks));
            for (int col = row; col > 0; col--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            blanks++;
        }
    }
}