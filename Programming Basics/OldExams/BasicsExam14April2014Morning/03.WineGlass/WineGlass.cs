using System;

public class WineGlass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int top = n / 2;
        int middle = 0;

        if (n >= 12)
            middle = n / 2 - 2;
        else
            middle = n / 2 - 1;

        int bottom = n - (top + middle);
        int dots = 1;
        int asterisks = n - 4;

        for (int i = 0; i < top; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("\\{0}/",
                    new string('*', n - 2));
            }
            else
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('.', dots),
                    new string('*', asterisks));
                dots++;
                asterisks -= 2;
            }
        }

        for (int i = 0; i < middle; i++)
        {
            Console.WriteLine("{0}||{0}",
                new string('.', dots - 1));
        }

        for (int i = 0; i < bottom; i++)
        {
            Console.WriteLine(new string('-', n));
        }
    }
}
