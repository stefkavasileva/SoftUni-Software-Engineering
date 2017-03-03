using System;

public class NakovsMatching
{
    public static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int limitNumber = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= a.Length - 1; i++)
        {
            string aLeft = a.Substring(0, i);
            string aRight = a.Substring(i);

            for (int j = 1; j <= b.Length - 1; j++)
            {
                string bLeft = b.Substring(0, j);
                string bRight = b.Substring(j);
                int totalWeight = Math.Abs(SumOfWeight(aLeft, aRight, bLeft, bRight));

                if (totalWeight <= limitNumber)
                {
                    Console.WriteLine($"({aLeft}|{aRight}) matches ({bLeft}|{bRight}) by {totalWeight} nakovs");
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    public static int SumOfWeight(string aLeft, string aRight, string bLenft, string bRight)
    {
        int wALeft = 0;
        int wARight = 0;
        int wBLeft = 0;
        int wBRight = 0;

        for (int i = 0; i < aLeft.Length; i++)
        {
            wALeft += aLeft[i];
        }

        for (int i = 0; i < aRight.Length; i++)
        {
            wARight += aRight[i];
        }

        for (int i = 0; i < bLenft.Length; i++)
        {
            wBLeft += bLenft[i];
        }

        for (int i = 0; i < bRight.Length; i++)
        {
            wBRight += bRight[i];
        }

        int totalWeight = (wALeft * wBRight) - (wARight * wBLeft);
        return totalWeight;
    }
}

