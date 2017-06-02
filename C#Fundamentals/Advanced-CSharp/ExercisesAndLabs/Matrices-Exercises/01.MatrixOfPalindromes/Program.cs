using System;
using System.Linq;
using System.Text;

namespace _01.MatrixOfPalindromes
{
    public class Program
    {
        public static void Main()
        {
            var matrixSizez = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(matrixSizez.First());
            var cols = int.Parse(matrixSizez[1]);
            var matrix = new string[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new string[cols];
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    var firstLetter = (char)(97 + rowIndex);
                    var seconLetter = (char)(97 + (rowIndex + colIndex));
                    var element = $"{firstLetter}{seconLetter}{firstLetter}";
                    matrix[rowIndex][colIndex] = element;
                }
            }

            var result = new StringBuilder();
            foreach (var row in matrix)
            {
                result.AppendLine(string.Join(" ", row));
            }

            Console.Write(result);
        }
    }
}
