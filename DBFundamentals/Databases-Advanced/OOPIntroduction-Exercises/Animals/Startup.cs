using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var cats = new List<Cat>();
        var dogs = new List<Dog>();
        var snakes = new List<Snake>();

        while (!inputLine.Equals("I'm your Huckleberry"))
        {
            var tokens = inputLine.Split();

            if (tokens.Length < 4)
            {
                var animalName = tokens[1];
                var sound = string.Empty;

                if (cats.Any(c => c.Name == animalName))
                {
                    sound = "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
                }
                else if (dogs.Any(d => d.Name == animalName))
                {
                    sound = "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
                }
                else if (snakes.Any(s => s.Name == animalName))
                {
                    sound = "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
                }

                Animal.ProduceSound(sound);
                inputLine = Console.ReadLine();
                continue;
            }

            var className = tokens[0];
            var name = tokens[1];
            var age = int.Parse(tokens[2]);
            var parameter = int.Parse(tokens[3]);

            if (className.Equals("Dog"))
            {
                var dog = new Dog { Age = age, Name = name, NumberOfLegs = parameter };
                dogs.Add(dog);
            }
            else if (className.Equals("Cat"))
            {
                var cat = new Cat { Age = age, Name = name, IntelligenceQuotient = parameter };
                cats.Add(cat);
            }
            else
            {
                var snake = new Snake { Age = age, Name = name, CrueltyCoefficient = parameter };
                snakes.Add(snake);
            }

            inputLine = Console.ReadLine();
        }

        foreach (var dog in dogs)
        {
            Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
        }

        foreach (var cat in cats)
        {
            Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
        }

        foreach (var snake in snakes)
        {
            Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
        }
    }
}

