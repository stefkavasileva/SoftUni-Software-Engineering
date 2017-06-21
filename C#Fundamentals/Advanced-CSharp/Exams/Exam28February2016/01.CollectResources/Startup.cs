using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CollectResources
{
    public class Startup
    {
        public static void Main()
        {
            var resourse = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var pathCount = int.Parse(Console.ReadLine());

            var indexes = new List<int>();

            var maxScore = long.MinValue;
            for (int i = 0; i < pathCount; i++)
            {
                var pathArgs = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                var startIndex = pathArgs[0];
                var steps = pathArgs[1];

                var currentScore = 0L;
                while (true)
                {
                    if (indexes.Contains(startIndex)) break;
                    indexes.Add(startIndex);
                    var resourseArgs = resourse[startIndex].Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

                    if (IsValidResourse(resourseArgs[0]))
                    {
                        var value = 1;
                        if (resourseArgs.Length > 1)
                        {
                            value = int.Parse(resourseArgs[1]);
                        }

                        currentScore += value;
                    }

                    startIndex += steps;
                    startIndex %= resourse.Length;
                }

                if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                }

                currentScore = 0;
                indexes.Clear();
            }

            Console.WriteLine(maxScore);
        }

        private static bool IsValidResourse(string resourseName)
        {

            if (resourseName.Equals("stone") || resourseName.Equals("gold") || resourseName.Equals("wood") ||
                resourseName.Equals("food"))
            {
                return true;
            }

            return false;
        }
    }
}
