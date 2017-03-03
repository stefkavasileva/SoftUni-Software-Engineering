using System;

public class EncodedAnswers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string answer = "";
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;

        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());
            if (num % 4 == 0)
            {
                answer = answer + "a ";
                a++;
            }
            else if (num % 4 == 1)
            {
                answer = answer + "b ";
                b++;
            }
            else if (num % 4 == 2)
            {
                answer = answer + "c ";
                c++;
            }
            else if (num % 4 == 3)
            {
                answer = answer + "d ";
                d++;
            }
        }

        Console.WriteLine(answer);
        Console.WriteLine("Answer A: {0}", a);
        Console.WriteLine("Answer B: {0}", b);
        Console.WriteLine("Answer C: {0}", c);
        Console.WriteLine("Answer D: {0}", d);
    }
}
