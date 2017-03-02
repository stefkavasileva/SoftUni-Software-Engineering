using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EqualPairs
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int firstSum = 0;
        int secondSum = 0;
        int maxDiff = int.MinValue;
        bool isEquals = true;

        for (int i = 0; i < n; i++)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                firstSum = firstSum + secondNum;
            }
            else
            {
                firstSum = firstSum + secondNum;
                if (firstSum == secondSum && isEquals)
                {
                    continue;

                }
                else
                {
                    isEquals = false;
                    int diff = Math.Abs(firstSum - secondSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }

            secondSum = firstSum;
        }

        if (maxDiff == int.MinValue)
        {
            Console.WriteLine("Yes, value={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}

