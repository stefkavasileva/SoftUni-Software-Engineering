using System;
using System.Linq;


class EqualSums
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool hasEqualSum = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = numbers.Take(i).Sum();
            int rightSum = numbers.Skip(i + 1).Sum();
            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                hasEqualSum = true;
                break;
            }
        }

        if (!hasEqualSum)
        {
            Console.WriteLine("no");
        }
    }
}

