using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountSameValuesInArray
{
    public class Startup
    {
        public static void Main()
        {
            var numbersCount = new SortedDictionary<double, int>();

            var inputNumbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            foreach (var inputNumber in inputNumbers)
            {
                if (!numbersCount.ContainsKey(inputNumber))
                {
                    numbersCount.Add(inputNumber,0);
                }

                numbersCount[inputNumber]++;
            }

            foreach (var number in numbersCount)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }          
        }
    }
}
