using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AnimalClinic
{      
    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var tokens = inputLine.Split();
                var animal = new Animal(tokens[0], tokens[1]);

                if (tokens[2].Equals("heal"))
                {
                    animal.state = "healed";
                    AnimalClinic.healedAnimalsCount++;
                }
                else
                {
                    animal.state = "rehabilitated";
                    AnimalClinic.rehabilitedAnimalsCount++;
                }

                Console.WriteLine(animal);
                animals.Add(animal);
                inputLine = Console.ReadLine();
            }
        
            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");

            var type = Console.ReadLine();

            animals = type.Equals("heal")
                ? animals.Where(a => a.state.Equals("healed")).ToList()
                : animals.Where(a => !a.state.Equals("healed")).ToList();

            animals.ForEach(x => Console.WriteLine($"{x.name} {x.breed}"));
        }
    }
}
