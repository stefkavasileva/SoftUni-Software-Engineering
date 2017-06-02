using System;
using System.Linq;
using System.Text;

namespace _04.MaximalSum
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

            var maxSum = int.MinValue;
            var maxRowIndex = 0;
            var maxColIndex = 0;
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var currentSum = GetCurrentSum(matrix, row, col);
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            PrintMaxSquare(maxRowIndex, maxColIndex, matrix);
        }

        private static void PrintMaxSquare(int maxRowIndex, int maxColIndex, int[][] matrix)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{matrix[maxRowIndex][maxColIndex]} {matrix[maxRowIndex][maxColIndex + 1]} {matrix[maxRowIndex][maxColIndex + 2]}");
            sb.AppendLine($"{matrix[maxRowIndex + 1][maxColIndex]} {matrix[maxRowIndex + 1][maxColIndex + 1]} {matrix[maxRowIndex + 1][maxColIndex + 2]}");
            sb.AppendLine($"{matrix[maxRowIndex + 2][maxColIndex]} {matrix[maxRowIndex + 2][maxColIndex + 1]} {matrix[maxRowIndex + 2][maxColIndex + 2]}");
            Console.Write(sb);
        }

        private static int GetCurrentSum(int[][] matrix, int rowIndex, int colIndex)
        {
            return matrix[rowIndex][colIndex] +
                   matrix[rowIndex][colIndex + 1] +
                   matrix[rowIndex][colIndex + 2] +
                   matrix[rowIndex + 1][colIndex] +
                   matrix[rowIndex + 1][colIndex + 1] +
                   matrix[rowIndex + 1][colIndex + 2] +
                   matrix[rowIndex + 2][colIndex] +
                   matrix[rowIndex + 2][colIndex + 1] +
                   matrix[rowIndex + 2][colIndex + 2];
        }
    }
}
