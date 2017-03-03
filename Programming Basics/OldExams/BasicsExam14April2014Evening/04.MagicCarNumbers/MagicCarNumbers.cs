using System;

public class MagicCarNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] letters = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        int sumLetters = 0;
        int count = 0;

        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                sumLetters = letters[i] + letters[j];
                for (int a = 0; a <= 9; a++)
                {
                    if (4 * a + 40 + sumLetters == n)
                    {
                        count++;
                    }

                    for (int b = 0; b <= 9; b++)
                    {
                        if (a != b)
                        {
                            if (a + 3 * b + 40 + sumLetters == n)
                            {
                                count++;
                            }
                            if (3 * a + b + 40 + sumLetters == n)
                            {
                                count++;
                            }
                            if (2 * a + 2 * b + 40 + sumLetters == n)
                            {
                                count = count + 3;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}