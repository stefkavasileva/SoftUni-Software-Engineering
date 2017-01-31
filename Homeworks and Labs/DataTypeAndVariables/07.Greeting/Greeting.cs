using System;

public class Greeting
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
    }
}
