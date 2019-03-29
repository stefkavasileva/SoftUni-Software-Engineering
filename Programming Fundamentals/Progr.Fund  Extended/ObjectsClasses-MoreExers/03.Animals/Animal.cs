using System;

public class Animal
{
    public string Name { get; set; }

    public int Age { get; set; }

    public static void ProduceSound(string sound)
    {
        Console.WriteLine(sound);
    }
}

