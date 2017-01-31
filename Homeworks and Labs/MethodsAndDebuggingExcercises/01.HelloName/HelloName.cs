using System;

public class HelloName
{
    public static void Main()
    {
        string personName = Console.ReadLine();
        PrintGreeting(personName);
    }

    private static void PrintGreeting(string personName)
    {
        Console.WriteLine($"Hello, {personName}!");
    }
}
