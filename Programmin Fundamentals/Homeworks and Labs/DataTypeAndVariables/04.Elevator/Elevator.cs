using System;

public class Elevator
{
    public static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        int capacityOfElevator = int.Parse(Console.ReadLine());

        double neededCourses = (double)peopleCount / capacityOfElevator;

        Console.WriteLine(Math.Ceiling(neededCourses));
    }
}