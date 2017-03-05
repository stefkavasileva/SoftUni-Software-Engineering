using System;

public class NumberInRange1To100
{
    public static void Main()
    {
        int num = 0;

        while (true)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("The number is: {0}", num);
                return;
            }
        }
    }
}
