using System;
using System.Text;

namespace _04.PascalTriangle
{
    public class StartUp
    {
        public static void Main()
        {
            var rowsCount = int.Parse(Console.ReadLine());
            var pascal = new long[rowsCount][];

            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                pascal[rowIndex] = new long[rowIndex + 1];
                pascal[rowIndex][0] = 1;
                pascal[rowIndex][pascal[rowIndex].Length - 1] = 1;

                for (int colIndex = 1; colIndex < pascal[rowIndex].Length - 1; colIndex++)
                {
                    pascal[rowIndex][colIndex] = pascal[rowIndex - 1][colIndex - 1] + pascal[rowIndex - 1][colIndex];
                }
            }

            var result = new StringBuilder();
            foreach (var row in pascal)
            {
                result.AppendLine(string.Join(" ", row));
            }

            Console.Write(result);
        }
    }
}
