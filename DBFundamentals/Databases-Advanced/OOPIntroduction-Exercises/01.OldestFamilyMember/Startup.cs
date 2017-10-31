using System;
using System.Collections.Generic;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        var familyList = new Family();

        var peopleCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < peopleCount; i++)
        {
            var personInfo = Console.ReadLine().Split();
            familyList.AddMember(new Person(personInfo[0],int.Parse(personInfo[1])));
        }

        Console.WriteLine(familyList.GetOldestMember());
    }
}

