using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main(string[] args)
    {
        var animals = new List<Animal>();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("Beast!"))
        {
            try
            {
                var typeOfAnimal = inputLine;
                var animalTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var animalName = animalTokens[0];
                var animalAge = int.Parse(animalTokens[1]);
                var gender = animalTokens[2];

                if (typeOfAnimal.Equals("Cat"))
                {
                    animals.Add(new Cat(animalName, animalAge, gender));
                }
                else if (typeOfAnimal.Equals("Tomcat"))
                {
                    animals.Add(new Tomcat(animalName, animalAge, "Male"));
                }
                else if (typeOfAnimal.Equals("Kitten"))
                {
                    animals.Add(new Kitten(animalName, animalAge, "Female"));
                }
                else if (typeOfAnimal.Equals("Frog"))
                {
                    animals.Add(new Frog(animalName, animalAge, gender));
                }
                else if (typeOfAnimal.Equals("Dog"))
                {
                    animals.Add(new Dog(animalName, animalAge, gender));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            inputLine = Console.ReadLine();
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType());
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            Console.WriteLine(animal.ProduceSound());
        }
    }
}

