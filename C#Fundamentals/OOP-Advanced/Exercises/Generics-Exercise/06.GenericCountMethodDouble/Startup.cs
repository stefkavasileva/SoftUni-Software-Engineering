using System;

public class Startup
{
    public static void Main()
    {
        var myData = new Box<double>();
        var counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            myData.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine(myData.Compare(myData.Data, double.Parse(Console.ReadLine())));
    }
}

