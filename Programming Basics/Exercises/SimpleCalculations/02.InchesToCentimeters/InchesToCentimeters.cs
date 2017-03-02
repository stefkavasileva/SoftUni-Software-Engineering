using System;

public class InchesToCentimeters
{
    public static void Main()
    {
        Console.Write("Inches = ");

        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;

        Console.Write("Centimeters = ");

        Console.WriteLine(centimeters);
    }
}
