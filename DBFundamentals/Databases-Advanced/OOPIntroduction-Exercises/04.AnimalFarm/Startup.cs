using System;

public class Startup
{
    public static void Main()
    {
        try
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var chicken = new Chicken(name, age);
            Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

