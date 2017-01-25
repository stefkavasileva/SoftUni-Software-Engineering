using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrophonTheGrumpyCat
{
    static void Main(string[] args)
    {
        long[] priceRatings = Console.ReadLine().Split().Select(long.Parse).ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        string typeOfItems = Console.ReadLine();
        string typeOfPriceRatings = Console.ReadLine();

        long leftSum = GetLeftSum(priceRatings, entryPoint, typeOfItems, typeOfPriceRatings);

        long rightSum = GetRightSum(priceRatings, entryPoint, typeOfItems, typeOfPriceRatings);

        if (leftSum >= rightSum)
        {
            Console.WriteLine("Left - {0}", leftSum);
        }
        else
        {
            Console.WriteLine("Right - {0}", rightSum);

        }
    }

    private static long GetRightSum(long[] priceRatings, int entryPoint, string typeOfItems, string typeOfPriceRatings)
    {
        long rightSum = 0;
        for (int i = entryPoint + 1; i < priceRatings.Length; i++)
        {
            rightSum += GetCurrentValue(priceRatings, entryPoint, typeOfItems, typeOfPriceRatings, i);
        }

        return rightSum;
    }

    private static long GetLeftSum(long[] priceRatings, int entryPoint, string typeOfItems, string typeOfPriceRatings)
    {
        long leftSum = 0;
        for (int i = entryPoint - 1; i >= 0; i--)
        {
            leftSum += GetCurrentValue(priceRatings, entryPoint, typeOfItems, typeOfPriceRatings, i);
        }

        return leftSum;
    }

    private static long GetCurrentValue(long[] priceRatings, int entryPoint, string typeOfItems, string typeOfPriceRatings, int i)
    {
        long sum = 0;
        if (typeOfItems.Equals("cheap") && priceRatings[i] < priceRatings[entryPoint])
        {
            sum = IsValidNum(priceRatings, typeOfPriceRatings, i, sum);
        }
        else if (typeOfItems.Equals("expensive") && priceRatings[i] >= priceRatings[entryPoint])
        {
            sum = IsValidNum(priceRatings, typeOfPriceRatings, i, sum);
        }

        return sum;
    }

    private static long IsValidNum(long[] priceRatings, string typeOfPriceRatings, int i, long sum)
    {
        if (typeOfPriceRatings.Equals("positive") && priceRatings[i] > 0)
        {
            sum += priceRatings[i];
        }
        else if (typeOfPriceRatings.Equals("negative") && priceRatings[i] < 0)
        {
            sum += priceRatings[i];
        }
        else if (typeOfPriceRatings.Equals("all"))
        {
            sum += priceRatings[i];
        }

        return sum;
    }
}

