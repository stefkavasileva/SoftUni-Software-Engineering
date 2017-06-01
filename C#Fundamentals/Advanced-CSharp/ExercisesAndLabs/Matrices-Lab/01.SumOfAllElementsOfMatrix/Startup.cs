using System;
using System.Linq;

namespace _01.SumOfAllElementsOfMatrix
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var rows = matrixSizes.First();
            var cols = matrixSizes.Last();

            var matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(matrix.Select(x => x.Sum()).Sum());
            
        }
    }
}
