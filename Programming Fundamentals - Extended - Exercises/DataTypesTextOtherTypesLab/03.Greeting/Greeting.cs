using System;

public class Greeting
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
    }
}
