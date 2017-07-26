using System;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var name = $"{input[0]} {input[1]}";
        var address = input[2];

        Console.WriteLine(new Tuple<string, string>(name, address));

        input = Console.ReadLine().Split();
        name = input[0];
        var litersOfBeer = int.Parse(input[1]);

        Console.WriteLine(new Tuple<string, int>(name, litersOfBeer));

        input = Console.ReadLine().Split();
        var integer = int.Parse(input[0]);
        var doubleValue = double.Parse(input[1]);

        Console.WriteLine(new Tuple<int, double>(integer, doubleValue));
    }
}

