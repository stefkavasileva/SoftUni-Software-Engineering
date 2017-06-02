using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    public class Program
    {
        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize][];

            for (int rowIndex = 0; rowIndex < matrixSize; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var mainDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (rowIndex == colIndex)
                    {
                        mainDiagonalSum += matrix[rowIndex][colIndex];
                    }

                    if (rowIndex + colIndex == matrixSize - 1)
                    {
                        secondaryDiagonalSum += matrix[rowIndex][colIndex];
                    }
                }
            }

            Console.WriteLine(Math.Abs(mainDiagonalSum - secondaryDiagonalSum));
        }
    }
}
