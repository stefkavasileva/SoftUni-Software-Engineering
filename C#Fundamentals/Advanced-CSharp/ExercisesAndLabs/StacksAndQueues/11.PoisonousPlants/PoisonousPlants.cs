using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
	//11/100
        var count = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var plants = new Queue<int>();
        numbers.ForEach(x => plants.Enqueue(x));

        var days = 0;
        var lastPlant = numbers[numbers.Count - 1];
        var middlePlants = new Queue<int>();
        var counter = 0;
        var haveToAdd = true;
        while (true)
        {
            if (plants.Peek() == lastPlant && counter > 0)
            {
                days++;
                plants.Dequeue();

                if (count == plants.Count)
                {
                    break;
                }

                count = plants.Count();
                continue;
            }

            var firstPlant = plants.Dequeue();

            if (plants.Peek() < firstPlant)
            {
                if (haveToAdd)
                {
                    plants.Enqueue(firstPlant);
                }

                plants.Enqueue(plants.Peek());
                haveToAdd = true;
            }
            else if (plants.Peek() > firstPlant)
            {
                haveToAdd = false;
            }

            counter++;
        }

        Console.WriteLine(days);
    }
}
