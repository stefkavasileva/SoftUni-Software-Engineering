using System;
using System.Collections.Generic;

public class CrossingSequences
{
    public static void Main()
    {
        long num1 = long.Parse(Console.ReadLine());
        long num2 = long.Parse(Console.ReadLine());
        long num3 = long.Parse(Console.ReadLine());
        long spiralStart = int.Parse(Console.ReadLine());
        long spiralStep = long.Parse(Console.ReadLine());

        List<long> tribonacci = new List<long>() { num1, num2, num3 };
        List<long> spiral = new List<long>() { spiralStart };
        bool check = false;

        while (num3 <= 1000000)
        {
            long ctemp = num3;
            num3 = num1 + num2 + num3;
            num1 = num2;
            num2 = ctemp;

            if (num3 > 1000000)
            {
                break;
            }

            tribonacci.Add(num3);
        }

        for (long poss = 1; spiralStart <= 1000000; poss++)
        {
            for (int m = 0; m < 2; m++)
            {
                long spiralStartTemp = spiralStart + poss * spiralStep;
                spiral.Add(spiralStartTemp);
                spiralStart = spiralStartTemp;
            }
        }

        foreach (var item in tribonacci)
        {
            if (spiral.Contains(item))
            {
                Console.WriteLine(item);
                check = true;
                return;
            }
        }

        if (!check)
        {
            Console.WriteLine("No");

        }
    }
}
