using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        //83/100
        var animals = new List<Animal>();

        var animalTypeAsStr = Console.ReadLine();

        while (!animalTypeAsStr.Equals("Beast!"))
        {
            var animalType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == animalTypeAsStr);

            if (animalType is null)
            {
                throw new ArgumentException(ErrorMessages.InvalidInput);
            }

            var animalArgs = Console.ReadLine().Split();
            var animalName = animalArgs[0];
            var animalAge = int.Parse(animalArgs[1]);
            var animalGender = string.Empty;
            if (animalType.Name == typeof(Kitten).Name)
            {
                animalGender = "Female";
            }
            else if (animalType.Name == typeof(Tomcat).Name)
            {
                animalGender = "Male";
            }
            else
            {
                animalGender = animalArgs[2];
            }

            try
            {
                var animal =
                                (Animal)Activator
                                .CreateInstance(animalType, new object[] { animalName, animalAge, animalGender });
                animals.Add(animal);
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
                else
                {
                    Console.WriteLine(e.Message);
                }
            }

            animalTypeAsStr = Console.ReadLine();
        }

        animals.ForEach(x => Console.Write(x));
    }
}

