using System;
using System.Linq;

namespace _06.TargetPractice
{
    public class Startup
    {
        public static void Main()
        {
            //70/100
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var rows = matrixSizes.First();
            var cols = matrixSizes.Last();
            var snakeSymbols = Console.ReadLine();

            var matrix = new char[rows][];
            FillTheMarix(matrix, snakeSymbols, cols);

            var shorParams = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var impactRow = shorParams[0];
            var impactCol = shorParams[1];
            var radius = shorParams[2];

            ShotTheMatrix(matrix, impactRow, impactCol, radius);


            for (int colIndex = 0; colIndex < cols; colIndex++)
            {
                var row = matrix.Length - 1;
                while (row > 0)
                {
                    if (matrix[row][colIndex] == ' ')
                    {
                        var nextLetterIndex = FindRowIndex(matrix, colIndex, row);
                        matrix[row][colIndex] = matrix[nextLetterIndex][colIndex];
                        matrix[nextLetterIndex][colIndex] = ' ';
                    }

                    row--;
                }
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    Console.Write(matrix[rowIndex][colIndex]);
                }

                Console.WriteLine();
            }

        }

        public static int FindRowIndex(char[][] matrix, int col, int row)
        {
            for (int i = row - 1; i >= 0; i--)
            {
                if (matrix[i][col] != ' ')
                {
                    return i;
                }
            }

            return 0;
        }

        public static void ShotTheMatrix(char[][] matrix, int impactRow, int impactCol, int radius)
        {
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    var ditance = (colIndex - impactCol) * (colIndex - impactCol) +
                                  (rowIndex - impactRow) * (rowIndex - impactRow);
                    if (ditance <= radius * radius)
                    {
                        matrix[rowIndex][colIndex] = ' ';
                    }
                }
            }
        }

        public static void FillTheMarix(char[][] matrix, string snakeSymbols, int cols)
        {
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new char[cols];
            }

            var counter = 0;
            for (int rowIndex = matrix.Length - 1; rowIndex >= 0; rowIndex--)
            {
                if (rowIndex % 2 != 0)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        matrix[rowIndex][colIndex] = snakeSymbols[counter % snakeSymbols.Length];
                        counter++;
                    }

                    continue;
                }

                for (int colIndex = matrix[rowIndex].Length - 1; colIndex >= 0; colIndex--)
                {
                    matrix[rowIndex][colIndex] = snakeSymbols[counter % snakeSymbols.Length];
                    counter++;
                }
            }
        }
    }
}
