using System;

public class Diamond
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstSegment = 0;
        int asterisks = 0;
        int outerDashes = 0;
        int middleDashes = 0;

        if (n % 2 == 0)
        {
            firstSegment = n / 2;
            asterisks = 2;
            outerDashes = (n - 2) / 2;
            middleDashes = 2;
        }
        else
        {
            firstSegment = (n + 1) / 2;
            asterisks = 1;
            outerDashes = (n - 1) / 2;
            middleDashes = 1;
        }

        for (int i = 0; i < firstSegment; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', asterisks));
                outerDashes--;
                continue;
            }

            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', middleDashes));
            outerDashes--;
            middleDashes += 2;
        }

        outerDashes = 1;
        middleDashes = n - 4;

        for (int i = 0; i < firstSegment - 1; i++)
        {
            if (i == firstSegment - 2)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', asterisks));
                continue;
            }

            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', middleDashes));
            outerDashes++;
            middleDashes -= 2;
        }
    }
}
