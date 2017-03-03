using System;
using System.Collections.Generic;

public class MorseCodeNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int n1 = (n / 1000) % 10;
        int n2 = (n / 100) % 10;
        int n3 = (n / 10) % 10;
        int n4 = n % 10;

        List<string> moreseNumber = new List<string>();
        int nSum = n1 + n2 + n3 + n4;

        for (int i1 = 0; i1 <= 5; i1++)
        {
            for (int i2 = 0; i2 <= 5; i2++)
            {
                for (int i3 = 0; i3 <= 5; i3++)
                {
                    for (int i4 = 0; i4 <= 5; i4++)
                    {
                        for (int i5 = 0; i5 <= 5; i5++)
                        {
                            for (int i6 = 0; i6 <= 5; i6++)
                            {
                                int morseProduct = i1 * i2 * i3 * i4 * i5 * i6;
                                if (nSum == morseProduct)
                                {
                                    moreseNumber.Add(new string('.', i1) + new string('-', 5 - i1) + "|" +
                                        new string('.', i2) + new string('-', 5 - i2) + "|" +
                                        new string('.', i3) + new string('-', 5 - i3) + "|" +
                                        new string('.', i4) + new string('-', 5 - i4) + "|" +
                                        new string('.', i5) + new string('-', 5 - i5) + "|" +
                                        new string('.', i6) + new string('-', 5 - i6) + "|");
                                }
                            }
                        }
                    }
                }
            }
        }

        if (moreseNumber.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (var item in moreseNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}
