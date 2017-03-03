using System;

public class WeirdCombinations
{
    public static void Main()
    {
        char[] letters = Console.ReadLine().ToCharArray();
        int currentElement = int.Parse(Console.ReadLine());

        int counter = -1;
        bool isSpecialElement = false;

        for (int i1 = 0; i1 < 5; i1++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    for (int i4 = 0; i4 < 5; i4++)
                    {
                        for (int i5 = 0; i5 < 5; i5++)
                        {
                            counter++;
                            if (counter == currentElement)
                            {
                                Console.WriteLine($"{letters[i1]}{letters[i2]}{letters[i3]}{letters[i4]}{letters[i5]}");
                                isSpecialElement = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        if (!isSpecialElement)
        {
            Console.WriteLine("No");
        }
    }
}
