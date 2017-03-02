using System;

public class BooleanVariable
{
    public static void Main()
    {
        string trueOrFalse = Console.ReadLine();

        bool isTrue = Convert.ToBoolean(trueOrFalse);

        if (isTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
