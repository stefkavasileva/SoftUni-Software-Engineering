using System;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        Type personType = typeof(Person);
        PropertyInfo[] properties = personType.GetProperties
            (BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(properties.Length);

        var firstPerson = new Person();
        firstPerson.Name = "Pesho";
        firstPerson.Age = 20;

        var secondPerson = new Person("Gosho",18);
        var thirdPerson = new Person("Stamat",43);  
    }
}
