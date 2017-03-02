using System;

public class SpecialNumbers
{
    public static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numbersCount; i++)
        {
            int sum = 0;
            int currentNum = i;
            while (currentNum > 0)
            {
                sum += currentNum % 10;
                currentNum /= 10;
            }

            bool isSpecialNumber = sum == 7 || sum == 5 || sum == 11;
            Console.WriteLine($"{i} -> {isSpecialNumber}");
        }
    }
}