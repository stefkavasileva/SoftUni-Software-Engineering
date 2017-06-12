using System;
using System.Linq;

namespace _02.CubicsRube
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0L;
            var freeDimensions = (int)Math.Pow(n, 3);

            var input = Console.ReadLine();
            while (!input.Equals("Analyze"))
            {
                var inputNumbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var d1 = inputNumbers[0];
                var d2 = inputNumbers[1];
                var d3 = inputNumbers[2];
                var num = inputNumbers[3];
               
                if (d1 < n && d2 < n && d3 < n && d1 >= 0 && d2 >= 0 && d3 >= 0)
                {
                    sum += num;
                    if (num > 0)
                    {
                        freeDimensions--;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
            Console.WriteLine(freeDimensions);
        }
    }
}
