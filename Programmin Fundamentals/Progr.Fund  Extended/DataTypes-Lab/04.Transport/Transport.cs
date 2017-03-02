using System;

public class Transport
{
    public static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());

        int capacity = 24;

        int courses = (int)Math.Ceiling((double)peopleCount / capacity);

        Console.WriteLine(courses);
    }
}