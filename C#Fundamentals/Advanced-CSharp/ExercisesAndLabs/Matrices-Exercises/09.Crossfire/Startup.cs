using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Crossfire
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var matrix = new List<List<int>>();

            FillTheMatrix(matrix, int.Parse(matrixSizes[0]), int.Parse(matrixSizes[1]));

            var comand = Console.ReadLine();
            while (!comand.Equals("Nuke it from orbit"))
            {
                var comandArgs = comand
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                var row = comandArgs[0];
                var col = comandArgs[1];
                var radius = comandArgs[2];

                DestroyingCellls(matrix, row, col, radius);
                RemoveEmptyString(matrix);
                comand = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void RemoveEmptyString(List<List<int>> matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                matrix[rowIndex] = matrix[rowIndex].Where(x => x != 0).ToList();
                if (!matrix[rowIndex].Any())
                {
                    matrix.RemoveAt(rowIndex);
                    rowIndex--;
                }
            }
        }

        public static void PrintMatrix(List<List<int>> matrix)
        {
            var sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Count; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] != 0)
                    {
                        sb.Append($"{matrix[rowIndex][colIndex]} ");
                    }
                }

                sb.AppendLine();
            }

            Console.Write(sb);
        }

        public static void FillTheMatrix(List<List<int>> matrix, int rows, int cols)
        {
            var counter = 1;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix.Add(new List<int>());
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex].Add(counter);
                    counter++;
                }
            }
        }

        public static void DestroyingCellls(List<List<int>> matrix, int row, int col, int radius)
        {
            if (row >= 0 && row < matrix.Count)
            {
                for (int colIndex = Math.Max(0, col - radius); colIndex <= Math.Min(col + radius, matrix[row].Count - 1); colIndex++)
                {
                    matrix[row][colIndex] = 0;
                }
            }

            if (col >= 0 && col < matrix[0].Count)
            {
                for (int rowIndex = Math.Max(0, row - radius); rowIndex <= Math.Min(row + radius, matrix.Count - 1); rowIndex++)
                {
                    if (col < matrix[rowIndex].Count)
                    {
                        matrix[rowIndex][col] = 0;
                    }
                }
            }
        }

    }
}
