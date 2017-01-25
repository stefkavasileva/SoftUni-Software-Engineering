using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Numbers
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        double average = numbers.Average();

        int[] greaterFiveNums = numbers
            .Where(x => x > average)
            .OrderByDescending(x => x)
            .Take(5)
            .ToArray();

        if (greaterFiveNums.Length == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", greaterFiveNums));
        }
    }
}

