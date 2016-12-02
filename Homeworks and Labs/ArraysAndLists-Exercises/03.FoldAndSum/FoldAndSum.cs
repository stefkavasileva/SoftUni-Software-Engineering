using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FoldAndSum
{
    static void Main(string[] args)
    {

        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int lent = nums.Length / 4;
        int[] firstElements = new int[lent];
        int[] lastElements = new int[lent];
        int[] middleElements = new int[lent * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i < lent)
            {
                firstElements[i] = nums[i];
            }
            else if (i >= lent && i < lent * 3)
            {
                middleElements[i - lent] = nums[i];
            }
            else
            {
                lastElements[i - (lent * 2) - lent] = nums[i];
            }
        }

        Array.Reverse(firstElements);
        Array.Reverse(lastElements);
        int[] sumOfArrs = new int[2 * lent];

        for (int i = 0; i < sumOfArrs.Length; i++)
        {
            if (i < sumOfArrs.Length / 2)
            {
                sumOfArrs[i] = firstElements[i] + middleElements[i];
            }
            else
            {
                sumOfArrs[i] = lastElements[i - lent] + middleElements[i];

            }
        }

        foreach (int sum in sumOfArrs)
        {
            Console.Write(sum);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

