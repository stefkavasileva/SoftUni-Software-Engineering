using System;
using System.Linq;
using System.Text;

namespace _02.SquareWithMaximumSum
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(matrixSizes.First());
            
            var matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[i] = currentRow;
            }

            var rowIndex = 0;
            var colIndex = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = GetCurrentSum(matrix, row, col);
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            var result = new StringBuilder();

            result.AppendLine($"{matrix[rowIndex][colIndex]} {matrix[rowIndex][colIndex + 1]}");
            result.AppendLine($"{matrix[rowIndex + 1][colIndex]} {matrix[rowIndex + 1][colIndex + 1]}");
            result.Append(maxSum);

            Console.WriteLine(result);
        }

        private static int GetCurrentSum(int[][] matrix, int rowIndex, int colIndex)
        {
            return matrix[rowIndex][colIndex] + matrix[rowIndex][colIndex + 1] +
                   matrix[rowIndex + 1][colIndex] + matrix[rowIndex + 1][colIndex +1];
        }
    }
}
