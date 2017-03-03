using System;

public class FallenInLove
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = 2 * n;
        int innerDots = 0;
        int symbol = 0;

        for (int i = 1; i <= (n * 3) + 1; i++)
        {
            if (i >= 1 && i <= n)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                    new string('~', symbol),
                    new string('.', outerDots),
                    new string('.', innerDots));

                symbol++;
                innerDots += 2;
                outerDots -= 2;
            }
            else if (i > n && i <= 2 * n)
            {
                if (outerDots == 0)
                {
                    outerDots = 1;
                }
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                    new string('.', outerDots),
                    new string('~', symbol),
                    new string('.', innerDots));

                outerDots += 2;
                symbol--;
                innerDots -= 2;
            }
            else if (i == 2 * n + 1)
            {
                Console.WriteLine("{0}####{0}",
                    new string('.', outerDots));

                outerDots++;
            }
            else
            {
                Console.WriteLine("{0}##{0}",
                    new string('.', outerDots));
            }
        }
    }
}
