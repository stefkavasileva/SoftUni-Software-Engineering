using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var rows = matrixSizes.First();

            var matrix = new char[rows][];
            var equalsSquareCount = 0;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray();
            }

            for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                {
                    equalsSquareCount += IsEquals(matrix, rowIndex, colIndex);
                }
            }

            Console.WriteLine(equalsSquareCount);
        }

        private static int IsEquals(char[][] matrix, int rowIndex, int colIndex)
        {
            if (matrix[rowIndex][colIndex] == matrix[rowIndex][colIndex + 1] &&
                matrix[rowIndex][colIndex] == matrix[rowIndex + 1][colIndex] &&
                matrix[rowIndex][colIndex] == matrix[rowIndex + 1][colIndex + 1])
            {
                return 1;
            }

            return 0;
        }
    }
}
