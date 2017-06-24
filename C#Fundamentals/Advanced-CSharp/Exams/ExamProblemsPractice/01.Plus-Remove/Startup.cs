using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Plus_Remove
{
    public class Startup
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var allLines = new List<string>();
            while (!line.Equals("END"))
            {
                allLines.Add(line);
                line = Console.ReadLine();
            }

            var matrix = new char[allLines.Count][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = allLines[row].ToCharArray();
            }

            RemovePlusShape(matrix);
            var result = PrintMatrix(matrix);
            Console.Write(result);

        }

        private static string PrintMatrix(char[][] matrix)
        {
            var sb = new StringBuilder();
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].All(x => x == ' '))
                {
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine(string.Join("", matrix[row].Where(x => x != ' ')));
                }
            }

            return sb.ToString();
        }

        private static void RemovePlusShape(char[][] matrix)
        {
            for (int row = 1; row < matrix.Length - 1; row++)
            {
                for (int col = 1; col < matrix[row].Length - 1; col++)
                {
                    if (IsEquals(matrix, row, col))
                    {
                        matrix[row][col] = ' ';
                        matrix[row - 1][col] = ' ';
                        matrix[row + 1][col] = ' ';
                        matrix[row][col - 1] = ' ';
                        matrix[row][col + 1] = ' ';
                    }
                }
            }
        }

        private static bool IsEquals(char[][] matrix, int row, int col)
        {
            return char.ToLower(matrix[row][col]) == char.ToLower(matrix[row - 1][col]) && char.ToLower(matrix[row - 1][col]) == char.ToLower(matrix[row + 1][col]) &&
                   char.ToLower(matrix[row][col - 1]) == char.ToLower(matrix[row + 1][col]) && char.ToLower(matrix[row + 1][col]) == char.ToLower(matrix[row][col + 1]);
        }
    }
}
