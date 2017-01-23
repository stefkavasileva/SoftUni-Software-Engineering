using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniWaterSupplies
{
    static void Main(string[] args)
    {
        double amountOfWater = double.Parse(Console.ReadLine());
        double[] bottlesToFill = Console.ReadLine().Split().Select(double.Parse).ToArray();

        double bottleCapacity = double.Parse(Console.ReadLine());

        int endIndex = -1;
        bool hasWater = true;
        double leftWater = amountOfWater;
        if ((int)amountOfWater % 2 != 0)
        {
            Array.Reverse(bottlesToFill);
        }

        for (int index = 0; index < bottlesToFill.Length; index++)
        {
            leftWater -= bottleCapacity - bottlesToFill[index];
            if (leftWater < 0 && hasWater)
            {
                endIndex = index;
                hasWater = false;
            }
        }

        if (leftWater < 0)
        {
            Console.WriteLine("We need more water!");
            endIndex = amountOfWater % 2 == 0 ? endIndex : bottlesToFill.Length - 1 - endIndex;
            int leftBottle = amountOfWater % 2 == 0 ? bottlesToFill.Length - endIndex : endIndex + 1;
            Console.WriteLine($"Bottles left: {leftBottle}");
            Console.Write($"With indexes: ");


            for (int i = 0; i < leftBottle; i++)
            {
                if (i == leftBottle - 1)
                {
                    Console.WriteLine(endIndex);
                }
                else
                {
                    Console.Write(endIndex + ", ");
                    if (amountOfWater % 2 == 0)
                    {
                        endIndex++;
                    }
                    else
                    {
                        endIndex--;
                    }
                }
            }

            Console.WriteLine($"We need {Math.Abs(leftWater)} more liters!");
        }
        else
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {leftWater}l.");
        }
    }
}

