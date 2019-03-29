using System;
using System.Linq;

public class BlurFilter
{
    public static void Main()
    {
        ////90/100
        int blurAmount = int.Parse(Console.ReadLine());
        int[] matrixInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];

        long[][] matrix = new long[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split().Select(long.Parse).ToArray();
        }

        int[] coordinatesOfTheBlur = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int targetRow = coordinatesOfTheBlur[0];
        int targetCol = coordinatesOfTheBlur[1];

        int startRow = Math.Max(0, targetRow - 1);
        int endRow = Math.Min(rows - 1, targetRow + 1);

        int startCol = Math.Max(0, targetCol - 1);
        int endCol = Math.Min(cols - 1, targetCol + 1);

        for (int row = startRow; row <= endRow; row++)
        {
            for (int col = startCol; col <= endCol; col++)
            {
                matrix[row][col] += blurAmount;
            }
        }

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
