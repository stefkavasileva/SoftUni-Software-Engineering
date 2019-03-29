using System;
using System.Linq;

public class TrophonTheGrumpyCat
{
    public static void Main()
    {
        var prices = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var entryPoint = int.Parse(Console.ReadLine());
        var typeOfItems = Console.ReadLine();
        var typeOfPrice = Console.ReadLine();

        var leftPart = prices.Take(entryPoint).ToArray();
        var rightPart = prices.Skip(entryPoint + 1).ToArray();

        leftPart = typeOfItems.Equals("cheap") ?
            leftPart.Where(x => x < prices[entryPoint]).ToArray() :
            leftPart.Where(x => x >= prices[entryPoint]).ToArray();

        rightPart = typeOfItems.Equals("cheap") ?
            rightPart.Where(x => x < prices[entryPoint]).ToArray() :
            rightPart.Where(x => x >= prices[entryPoint]).ToArray();

        if (typeOfPrice.Equals("positive"))
        {
            leftPart = leftPart.Where(x => x > 0).ToArray();
            rightPart = rightPart.Where(x => x > 0).ToArray();
        }
        else if (typeOfPrice.Equals("negative"))
        {
            leftPart = leftPart.Where(x => x < 0).ToArray();
            rightPart = rightPart.Where(x => x < 0).ToArray();
        }

        long leftSum = leftPart.Sum();
        long rightSum = rightPart.Sum();

        if (leftSum >= rightSum)
        {
            Console.WriteLine($"Left - {leftSum}");
        }
        else
        {
            Console.WriteLine($"Right - {rightSum}");
        }
    }  
}