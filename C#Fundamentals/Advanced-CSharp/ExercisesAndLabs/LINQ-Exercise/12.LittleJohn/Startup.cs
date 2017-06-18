using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.LittleJohn
{
    public class Startup
    {
        public const string smallArrow = ">----->";
        public const string mediumArrow = ">>----->";
        public const string largeArrow = ">>>----->>";
        public static void Main()
        {
            //87/100
            var arrowCount = new Dictionary<string, long>();
            arrowCount.Add(smallArrow, 0);
            arrowCount.Add(mediumArrow, 0);
            arrowCount.Add(largeArrow, 0);

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (string.IsNullOrEmpty(inputLine)) break;

                arrowCount[largeArrow] += CountArrows(inputLine, largeArrow);
                inputLine = inputLine.Replace(largeArrow, string.Empty);

                arrowCount[mediumArrow] += CountArrows(inputLine, mediumArrow);
                inputLine = inputLine.Replace(mediumArrow, string.Empty);

                arrowCount[smallArrow] += CountArrows(inputLine, smallArrow);

            }

            var arrowNumber = long.Parse($"{arrowCount[smallArrow]}{arrowCount[mediumArrow]}{arrowCount[largeArrow]}");
            var binary = $"{Convert.ToString(arrowNumber, 2)}{new string(Convert.ToString(arrowNumber, 2).Reverse().ToArray())}";
            var result = Convert.ToInt64(binary, 2);
            Console.WriteLine(result);
        }

        private static long CountArrows(string inputLine, string arrowType)
        {
            var count = 0L;
            var index = -1;
            while (true)
            {
                index = inputLine.IndexOf(arrowType, index + 1);
                if (index == -1)
                {
                    break;
                }

                count++;
            }

            return count;
        }
    }
}