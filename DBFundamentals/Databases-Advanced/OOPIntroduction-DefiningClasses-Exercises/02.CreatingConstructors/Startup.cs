using System;

public class Startup
{
    public static void Main()
    {
        var personType = typeof(Person);
        var emptyCtor = personType.GetConstructor(new Type[] { });
        var ageCtor = personType.GetConstructor(new[] { typeof(int) });
        var nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
        var swapped = false;

        if (nameAgeCtor == null)
        {
            nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            swapped = true;
        }

        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        var basePerson = (Person)emptyCtor.Invoke(new object[] { });
        var personWithAge = (Person)ageCtor.Invoke(new object[] { age });
        var personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

        Console.WriteLine($"{basePerson.Name} {basePerson.Age}");
        Console.WriteLine($"{personWithAge.Name} {personWithAge.Age}");
        Console.WriteLine($"{personWithAgeAndName.Name} {personWithAgeAndName.Age}");
    }
}

