using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenElements
{
    static void Main(string[] args)
    {
        decimal[] inputNums = new decimal[] { };
        try
        {
            inputNums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        }
        catch (Exception)
        {

            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }

        List<decimal> oddNums = new List<decimal>();
        List<decimal> evenNums = new List<decimal>();
        for (int i = 1; i <= inputNums.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenNums.Add(inputNums[i - 1]);
            }
            else
            {
                oddNums.Add(inputNums[i - 1]);
            }
        }

        if (evenNums.Count == 0)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
           (double)oddNums.Sum(), (double)oddNums.Min(), (double)oddNums.Max());
            return;
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                      (double)oddNums.Sum(), (double)oddNums.Min(), (double)oddNums.Max(),
                      (double)evenNums.Sum(), (double)evenNums.Min(), (double)evenNums.Max());
        }


    }
}

