using System;
using System.Linq;

namespace _07.LegoBlocks
{
    public class Startup
    {
        public static long totalSells = 0;
        public static void Main()
        {
            var rowsInMatrices = int.Parse(Console.ReadLine());

            var firstMatrix = new string[rowsInMatrices][];
            var secondMatrix = new string[rowsInMatrices][];


            FillTheMatrix(firstMatrix, rowsInMatrices);
            FillTheMatrix(secondMatrix, rowsInMatrices);

            ReverseMatrix(secondMatrix);

            var newMatrix = new string[rowsInMatrices][];
            for (int rowIndex = 0; rowIndex < rowsInMatrices; rowIndex++)
            {
                newMatrix[rowIndex] = firstMatrix[rowIndex].Concat(secondMatrix[rowIndex]).ToArray();
            }

            var isFit = true;

            for (int rowIndex = 0; rowIndex < newMatrix.Length - 1; rowIndex++)
            {
                if (newMatrix[rowIndex].Length != newMatrix[rowIndex+1].Length)
                {
                    isFit = false;
                    break;
                }
            }

            if (isFit)
            {
                for (int rowIndex = 0; rowIndex < rowsInMatrices; rowIndex++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[rowIndex].Concat(secondMatrix[rowIndex]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalSells}");
            }

        }

        private static void PrintMatrix(string[][] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    Console.Write(matrix[rowIndex][colIndex] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void ReverseMatrix(string[][] secondMatrix)
        {
            for (int rowIndex = 0; rowIndex < secondMatrix.Length; rowIndex++)
            {
                Array.Reverse(secondMatrix[rowIndex]);
            }
        }

        private static void FillTheMatrix(string[][] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                totalSells += matrix[i].Length;
            }
        }
    }
}
