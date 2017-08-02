using System;
using System.Linq;

[Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]

public class Startup
{
    public static void Main()
    {
        CustomAttribute attribute = (CustomAttribute)typeof(Startup).GetCustomAttributes(false).FirstOrDefault();

        var input = Console.ReadLine();

        while (!input.Equals("END"))
        {
            Console.WriteLine(attribute.Print(input));

            input = Console.ReadLine();
        }
    }
}

