using System;

public class Startup
{
    public static void Main()
    {
        var myData = new Box<string>();
        var counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            myData.Add(Console.ReadLine());
        }

        Console.WriteLine(myData.Compare(myData.Data,Console.ReadLine()));
    }
}

