using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BlurFilter
{
    static void Main(string[] args)
    {
        //70/100
        long blurAmount = long.Parse(Console.ReadLine());
        long[] matrixInfo = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long rows = matrixInfo[0];
        long cols = matrixInfo[1];

        long[][] matrix = new long[rows][];

        for (long row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split().Select(long.Parse).ToArray();
        }

        int[] coordinatesOfTheBlur = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int targetRow = coordinatesOfTheBlur[0];
        int targetCol = coordinatesOfTheBlur[1];

        matrix[targetRow][targetCol] += blurAmount;



        if (targetRow - 1 >= 0 && targetCol - 1 >= 0)
        {
            matrix[targetRow - 1][targetCol - 1] += blurAmount;
        }

        if (targetCol - 1 >= 0 && targetCol + 1 <= cols - 1)
        {
            matrix[targetRow - 1][targetCol + 1] += blurAmount;
        }

        if (targetRow + 1 <= rows - 1 && targetCol + 1 <= cols - 1)
        {
            matrix[targetRow + 1][targetCol + 1] += blurAmount;
        }

        if (targetRow + 1 <= rows - 1 && targetCol - 1 >= 0)
        {
            matrix[targetRow + 1][targetCol - 1] += blurAmount;
        }

        if (targetRow + 1 <= rows - 1)
        {
            matrix[targetRow + 1][targetCol] += blurAmount;
        }

        if (targetCol - 1 >= 0)
        {
            matrix[targetRow][targetCol - 1] += blurAmount;
        }

        if (targetCol + 1 <= cols - 1)
        {
            matrix[targetRow][targetCol + 1] += blurAmount;
        }

        if (targetRow - 1 >= 0)
        {
            matrix[targetRow - 1][targetCol] += blurAmount;
        }

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }

    }
}

