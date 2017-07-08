using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var animals = new List<Animal>();

        var line = Console.ReadLine();
        while (!line.Equals("End"))
        {
            var animalArg = line.Split();
            var type = animalArg[0];

            if (type.Equals("Mouse"))
            {
                animals.Add(new Mouse(animalArg[1], double.Parse(animalArg[2]), animalArg[3]));
            }
            else if (type.Equals("Zebra"))
            {
                animals.Add(new Zebra(animalArg[1], double.Parse(animalArg[2]), animalArg[3]));
            }
            else if (type.Equals("Cat"))
            {
                animals.Add(new Cat(animalArg[1], double.Parse(animalArg[2]), animalArg[3], animalArg[4]));
            }
            else if (type.Equals("Tiger"))
            {
                animals.Add(new Tiger(animalArg[1], double.Parse(animalArg[2]), animalArg[3]));
            }

            Console.WriteLine(animals[animals.Count - 1].MakeSound());

            var foodArgs = Console.ReadLine().Split();
            var foodType = foodArgs[0];
            var quantity = int.Parse(foodArgs[1]);
            var curentFood = new Food[1];

            if (foodType.Equals("Meal"))
            {
                curentFood[0] = new Meat(quantity);
            }
            else
            {
                curentFood[0] = new Vegetable(quantity);
            }

            try
            {
                animals[animals.Count - 1].Eat(curentFood[0]);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }            

            Console.WriteLine(animals[animals.Count - 1]);

            line = Console.ReadLine();
        }
    }
}

