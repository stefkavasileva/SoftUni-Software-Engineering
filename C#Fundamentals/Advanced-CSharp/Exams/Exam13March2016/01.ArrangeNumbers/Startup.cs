using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ArrangeNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbersName = new string[]
                {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var numbers = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var numbersAndNames = new Dictionary<string,List<string>>();

            foreach (var number in numbers)
            {
                var sb = new StringBuilder();
                foreach (var digit in number)
                {
                    sb.Append(numbersName[(int)char.GetNumericValue(digit)]);
                }

                if (!numbersAndNames.ContainsKey(sb.ToString()))
                {
                    numbersAndNames.Add(sb.ToString(),new List<string>());
                }

                numbersAndNames[sb.ToString()].Add(number);
            }

            numbersAndNames = numbersAndNames.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var result = new StringBuilder();
            foreach (var kvp in numbersAndNames)
            {
                foreach (var number in kvp.Value)
                {
                    result.Append($"{number}, ");
                }               
            }

            Console.WriteLine(result.ToString().Trim(new []{' ',','}));
        }
    }
}
