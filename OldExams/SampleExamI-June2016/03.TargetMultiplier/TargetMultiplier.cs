using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TargetMultiplier
{
    static void Main(string[] args)
    {
        int[] matrixSizeInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = matrixSizeInfo[0];
        int cols = matrixSizeInfo[1];

        int[][] matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        int[] targetPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int targetRow = targetPositions[0];
        int targetCol = targetPositions[1];

        int neighborsCellsSum = matrix[targetRow][targetCol - 1] +
            matrix[targetRow][targetCol + 1] +
            matrix[targetRow + 1][targetCol] +
            matrix[targetRow + 1][targetCol - 1] +
            matrix[targetRow + 1][targetCol + 1] +
            matrix[targetRow - 1][targetCol] +
            matrix[targetRow - 1][targetCol - 1] +
            matrix[targetRow - 1][targetCol + 1];

        //update old value in neighbours cells 

        matrix[targetRow][targetCol - 1] *= matrix[targetRow][targetCol];
        matrix[targetRow][targetCol + 1] *= matrix[targetRow][targetCol];
        matrix[targetRow + 1][targetCol] *= matrix[targetRow][targetCol];
        matrix[targetRow + 1][targetCol - 1] *= matrix[targetRow][targetCol];
        matrix[targetRow + 1][targetCol + 1] *= matrix[targetRow][targetCol];
        matrix[targetRow - 1][targetCol] *= matrix[targetRow][targetCol];
        matrix[targetRow - 1][targetCol - 1] *= matrix[targetRow][targetCol];
        matrix[targetRow - 1][targetCol + 1] *= matrix[targetRow][targetCol];

        // update matget sell value

        matrix[targetRow][targetCol] *= neighborsCellsSum;

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

