using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PairsByDifference
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int currentDiff = int.Parse(Console.ReadLine());
        int pairs = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int diff = Math.Abs(numbers[i] - numbers[j]);
                if (currentDiff == diff)
                {
                    pairs++;
                }
            }
        }

        Console.WriteLine(pairs);
    }
}

