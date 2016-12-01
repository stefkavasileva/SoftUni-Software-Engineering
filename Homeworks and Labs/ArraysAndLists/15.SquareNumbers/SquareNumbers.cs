using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareNumbers
{
    static void Main(string[] args)
    {
        double[] inputNums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        List<double> squareNums = new List<double>();

        GetSqareNums(inputNums, squareNums);
        squareNums.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ",squareNums));
    }

    private static void GetSqareNums(double[] inputNums, List<double> squareNums)
    {
        for (int i = 0; i < inputNums.Length; i++)
        {
            double num = Math.Sqrt(inputNums[i]);
            if (num == (int)num)
            {
                squareNums.Add(inputNums[i]);
            }
        }
    }
}

