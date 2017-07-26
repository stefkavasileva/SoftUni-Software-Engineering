using System;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        Console.WriteLine(new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]));
     
        input = Console.ReadLine().Split();
        var drunkResult = !input[2].Equals("drunk") ? "False" : "True";
        Console.WriteLine(new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), bool.Parse(drunkResult)));

        input = Console.ReadLine().Split();

        Console.WriteLine(new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]));
    }
}

