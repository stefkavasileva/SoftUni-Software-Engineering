using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno
{
    public class Startup
    {
        public static void Main()
        {
            var gems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine().Split(';');
            var exclusionFilters = new Queue<KeyValuePair<string, int>>();

            while (input[0] != "Forge")
            {
                var command = input[0];
                var filterType = input[1];
                var filterParamenter = int.Parse(input[2]);

                if (command.Equals("Exclude"))
                {
                    exclusionFilters.Enqueue(new KeyValuePair<string, int>(filterType, filterParamenter));
                }
                else if (command.Equals("Reverse") && exclusionFilters.Count > 0)
                {
                    exclusionFilters.Dequeue();
                }

                input = Console.ReadLine().Split(';');
            }

            foreach (var filter in exclusionFilters)
            {

                if (filter.Key.Equals("Sum Left"))
                {
                    SumLeft(filter.Value, gems);
                }
                else if (filter.Key.Equals("Sum Right"))
                {
                    SumRight(filter.Value, gems);
                }
                else
                {
                    SumLeftRight(filter.Value, gems);
                }
            }

            Console.WriteLine(string.Join(" ", gems));
        }

        private static void SumLeftRight(int value, List<int> gems)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                var leftGemPower = (i == 0) ? 0 : gems[i - 1];
                var rightGemPower = (i == gems.Count - 1) ? 0 : gems[i + 1];

                if (leftGemPower + gems[i] + rightGemPower == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void SumRight(int value, List<int> gems)
        {
            while (gems.Last() == value && gems.Count > 0)
            {
                gems.RemoveAt(gems.Count - 1);
            }

            for (int i = 0; i < gems.Count - 1; i++)
            {
                if (gems[i] + gems[i + 1] == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void SumLeft(int value, List<int> gems)
        {
            while (gems.First() == value && gems.Count > 0)
            {
                gems.RemoveAt(0);
            }

            for (int i = gems.Count - 1; i > 0; i--)
            {
                if (gems[i] + gems[i - 1] == value)
                {
                    gems.RemoveAt(i);
                }
            }
        }
    }
}