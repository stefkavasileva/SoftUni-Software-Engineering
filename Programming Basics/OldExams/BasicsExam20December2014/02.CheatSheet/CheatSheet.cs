using System;

public class CheatSheet
{
    public static void Main()
    {
        int matrixRows = int.Parse(Console.ReadLine());
        int matrixCols = int.Parse(Console.ReadLine());
        int startRow = int.Parse(Console.ReadLine());
        int startCol = int.Parse(Console.ReadLine());

        for (long row = startRow; row < matrixRows + startRow; row++)
        {
            for (long col = startCol; col < matrixCols + startCol; col++)
            {
                Console.Write($"{row * col} ");
            }

            Console.WriteLine();
        }
    }
}