using System;

public class PlaidTowel
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char backgroundSymbol = char.Parse(Console.ReadLine());
        char rhombusSymbol = char.Parse(Console.ReadLine());

        int outerElement = size - 1;
        int innerElement = 1;
        int middleElement = (2 * size) - 3;

        for (int i = 1; i <= 5; i++)
        {
            if (i == 1 || i == 3 || i == 5)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                                new string(backgroundSymbol, size),
                                new string(rhombusSymbol, 1),
                                new string(backgroundSymbol, (2 * size) - 1));
                outerElement = size - 1;
                innerElement = 1;
                middleElement = (2 * size) - 3;
            }
            else
            {
                for (int j = 1; j <= (size * 2) - 1; j++)
                {
                    if (j == size)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}",
                       new string(backgroundSymbol, outerElement),
                       new string(rhombusSymbol, 1),
                       new string(backgroundSymbol, innerElement));
                    }
                    else if (j >= 1 && j < size)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                        new string(backgroundSymbol, outerElement),
                        new string(rhombusSymbol, 1),
                        new string(backgroundSymbol, innerElement),
                        new string(backgroundSymbol, middleElement));
                        outerElement--;
                        innerElement += 2;
                        middleElement -= 2;
                    }
                    else
                    {
                        if (middleElement == -1)
                        {
                            outerElement = 1;
                            innerElement -= 2;
                            middleElement = 1;
                        }

                        Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                                new string(backgroundSymbol, outerElement),
                                new string(rhombusSymbol, 1),
                                new string(backgroundSymbol, innerElement),
                                new string(backgroundSymbol, middleElement));
                        outerElement++;
                        innerElement -= 2;
                        middleElement += 2;
                    }
                }
            }
        }
    }
}
