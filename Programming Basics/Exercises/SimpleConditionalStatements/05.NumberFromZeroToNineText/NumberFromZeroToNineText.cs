using System;

public class NumberFromZeroToNineText
{
    public static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        if (inputNum == 0)
        {
            Console.WriteLine("zero");
        }
        else if (inputNum == 1)
        {
            Console.WriteLine("one");
        }
        else if (inputNum == 2)
        {
            Console.WriteLine("two");
        }
        else if (inputNum == 3)
        {
            Console.WriteLine("three");
        }
        else if (inputNum == 4)
        {
            Console.WriteLine("four");
        }
        else if (inputNum == 5)
        {
            Console.WriteLine("five");
        }
        else if (inputNum == 6)
        {
            Console.WriteLine("six");
        }
        else if (inputNum == 7)
        {
            Console.WriteLine("seven");
        }
        else if (inputNum == 8)
        {
            Console.WriteLine("eight");
        }
        else if (inputNum == 9)
        {
            Console.WriteLine("nine");
        }
        else
        {
            Console.WriteLine("number too big");
        }
    }
}