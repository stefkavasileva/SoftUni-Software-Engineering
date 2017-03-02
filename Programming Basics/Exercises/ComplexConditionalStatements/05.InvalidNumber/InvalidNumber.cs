using System;

public class InvalidNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if ((number < 100 || number > 200) && number != 0)
        {
            Console.WriteLine("invalid");
        }
    }
}