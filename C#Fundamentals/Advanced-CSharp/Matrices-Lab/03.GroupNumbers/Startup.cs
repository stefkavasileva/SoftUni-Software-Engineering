using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.GroupNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var matrix = new List<List<int>>();
            matrix.Add(new List<int>());
            matrix.Add(new List<int>());
            matrix.Add(new List<int>());

            foreach (var number in numbers)
            {
                if (Math.Abs(number) % 3 == 0)
                {
                    matrix[0].Add(number);
                }
                else if (Math.Abs(number) % 3 == 1)
                {
                    matrix[1].Add(number);
                }
                else if (Math.Abs(number) % 3 == 2)
                {
                    matrix[2].Add(number);
                }
            }

            var result = new StringBuilder();

            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                result.AppendLine(string.Join(" ", matrix[rowIndex]));
            }

            Console.Write(result);
        }
    }
}
