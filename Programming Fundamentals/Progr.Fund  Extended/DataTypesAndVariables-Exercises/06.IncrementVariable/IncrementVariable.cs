using System;

public class IncrementVariable
{
    public static void Main()
    {
        int incrementTimes = int.Parse(Console.ReadLine());
        int overFlowTimes = 0;

        byte number = 0;

        for (int i = 0; i < incrementTimes; i++)
        {
            number++;

            if (number == 0)
            {
                overFlowTimes++;
            }
        }

        Console.WriteLine(number);

        if (overFlowTimes > 0)
        {
            Console.WriteLine("Overflowed " + overFlowTimes + " times");
        }
    }
}