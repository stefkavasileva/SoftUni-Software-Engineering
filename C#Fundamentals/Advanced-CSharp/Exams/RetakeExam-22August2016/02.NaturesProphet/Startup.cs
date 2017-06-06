using System;
using System.Linq;
using System.Text;

namespace _02.NaturesProphet
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var matrix = new int[rows, cols];

            var input = Console.ReadLine();
            while (!input.Equals("Bloom Bloom Plow"))
            {
                var cell = input.Split().Select(int.Parse).ToArray();
                var row = cell[0];
                var col = cell[1];

                BloomFlowers(matrix, row, col, cols, rows);
                input = Console.ReadLine();
            }

            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append($"{matrix[i, j]} ");
                }

                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString().Trim());

        }

        private static void BloomFlowers(int[,] matrix, int row, int col, int cols, int rows)
        {
            matrix[row, col]++;
            for (int i = col - 1; i >= 0; i--)
            {
                matrix[row, i]++;
            }

            for (int i = col + 1; i < cols; i++)
            {
                matrix[row, i]++;
            }

            for (int i = row - 1; i >= 0; i--)
            {
                matrix[i, col]++;
            }

            for (int i = row + 1; i < rows; i++)
            {
                matrix[i, col]++;
            }
        }
    }
}
