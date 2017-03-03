using System;

public class WinningNumbers
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        int letSum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            letSum += text[i] - 96;
        }

        bool isWinningNum = false;

        for (int i1 = 0; i1 < 10; i1++)
        {
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    int firstSum = i1 * i2 * i3;

                    for (int i4 = 0; i4 < 10; i4++)
                    {
                        for (int i5 = 0; i5 < 10; i5++)
                        {
                            for (int i6 = 0; i6 < 10; i6++)
                            {
                                int secondSum = i4 * i5 * i6;
                                if (secondSum == letSum && firstSum == letSum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                        i1, i2, i3, i4, i5, i6);
                                    isWinningNum = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isWinningNum)
        {
            Console.WriteLine("No");
        }
    }
}
