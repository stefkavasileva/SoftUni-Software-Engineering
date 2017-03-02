using System;

public class ConcatenateData
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
    }
}
