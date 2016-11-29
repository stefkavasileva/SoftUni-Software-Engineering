using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Elevator
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        int capacityOfElevator = int.Parse(Console.ReadLine());

        double neededCourses = (double) peopleCount/capacityOfElevator;

        Console.WriteLine(Math.Ceiling(neededCourses));
    }
}
