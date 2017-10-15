using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KnightGame
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSize][];

            for (int rowIndex = 0; rowIndex < matrixSize; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToCharArray();
            }

            var isOver = false;
            while (!isOver)
            {
              var ma   GetMaxCount(matrix);

                var maxCount = int.MinValue;
                var count = 0;
                for (int row = 0; row < matrixSize; row++)
                {
                    for (int col = 0; col < matrixSize; col++)
                    {
                        if (matrix[row][col] != 'K') continue;

                        count += RemoveCount(matrix, row, col);
                        count += RemoveCount(matrix, col, row);


                    }
                }
            }

        }

        private static void GetMaxCount(char[][] matrix)
        {
            var counter = 0;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.Length; colIndex++)
                {
                    counter = GetNumberOfHourse(matrix, rowIndex, colIndex);

                }
            }

        }

        private static int GetNumberOfHourse(char[][] matrix, int rowIndex, int colIndex)
        {
            var counter = 0;
            if (rowIndex - 1 >= 0 && colIndex - 2 >= 0 && matrix[rowIndex - 1][colIndex - 2].Equals('K'))
            {
                counter++;
            }

            if (rowIndex - 1 >= 0 && colIndex + 2 > matrix.Length - 1 && matrix[rowIndex - 1][colIndex + 2].Equals('K'))
            {
                counter++;
            }

            if (rowIndex + 1 < matrix.Length - 1 && colIndex - 2 >= 0 && matrix[rowIndex + 1][colIndex - 2].Equals('K'))
            {
                counter++;
            }

            if (rowIndex + 1 < matrix.Length - 1 && colIndex + 2 < matrix.Length - 1 &&
                matrix[rowIndex + 1][colIndex + 2].Equals('K'))
            {
                counter++;
            }


            if (rowIndex - 2 >= 0 && colIndex + 1 < matrix.Length - 1 && matrix[rowIndex - 2][colIndex + 1].Equals('K'))
            {
                counter++;
            }

            if (rowIndex - 2 >= 0 && counter - 1 >= 0 && matrix[rowIndex - 2][colIndex - 1].Equals('K'))
            {
                counter++;
            }

            if (rowIndex + 2 < matrix.Length && colIndex - 1 >= 0 && matrix[rowIndex + 2][colIndex - 1].Equals('K'))
            {
                counter++;
            }

            if (rowIndex + 2 < matrix.Length && colIndex + 1 < matrix.Length - 1 &&
                matrix[rowIndex][colIndex - 1].Equals('K'))
            {
                counter++;
            }

            return counter;
        }

        private static void Remove(char[][] matrix, int row, int col)
        {
            if (row - 1 >= 0 && col + 2 < matrix.Length - 1 && matrix[row - 1][col + 2] == 'K')
            {
                matrix[row - 1][col + 2] = 'O';
            }

            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1][col - 2] == 'K')
            {
                matrix[row - 1][col - 2] = 'O';
            }

            if (row + 1 < matrix.Length - 1 && col + 2 < matrix.Length - 1 && matrix[row + 1][col + 2] == 'K')
            {
                matrix[row + 1][col + 2] = 'O';
            }

            if (row + 1 < matrix.Length - 1 && col - 2 >= 0 && matrix[row + 1][col - 2] == 'K')
            {
                matrix[row + 1][col - 2] = 'O';
            }

        }

        private static int RemoveCount(char[][] matrix, int row, int col)
        {
            var count = 0;

            if (row - 1 >= 0 && col + 2 < matrix.Length - 1 && matrix[row - 1][col + 2] == 'K')
            {
                count++;
            }

            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1][col - 2] == 'K')
            {
                count++;
            }

            if (row + 1 < matrix.Length - 1 && col + 2 < matrix.Length - 1 && matrix[row + 1][col + 2] == 'K')
            {
                count++;
            }

            if (row + 1 < matrix.Length - 1 && col - 2 >= 0 && matrix[row + 1][col - 2] == 'K')
            {
                count++;
            }

            return count;
        }
    }
}
