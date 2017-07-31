using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    private static IList<Pet> pets;
    private static IList<Clinic> clinics;

    public static void Main()
    {
        pets = new List<Pet>();
        clinics = new List<Clinic>();
        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            switch (command)
            {
                case "Create":

                    Create(args);
                    break;

                case "Add":
                    // Add {pet's name} {clinic's name}
                    Pet currentPet = pets.FirstOrDefault(p => p.Name.Equals(args[1]));
                    Console.WriteLine(clinics.FirstOrDefault(c => c.Name.Equals(args[2])).AddPet(currentPet));
                    break;

                case "Release":
                    // Release {clinic's name}
                    Console.WriteLine(clinics.FirstOrDefault(c => c.Name.Equals(args[1])).Release());
                    break;

                case "HasEmptyRooms":
                    // HasEmptyRooms {clinic’s name}
                    Console.WriteLine(clinics.FirstOrDefault(c => c.Name.Equals(args[1])).HasEmptyRooms());
                    break;

                case "Print":

                    Print(args);
                    break;
            }
        }
    }

    private static void Print(string[] args)
    {
        string clinicName = args[1];

        // Print {clinic's name}
        if (args.Length == 2)
        {
            Clinic currentClinic = clinics.FirstOrDefault(c => c.Name.Equals(clinicName));

            foreach (Pet pet in currentClinic)
            {
                if (pet != null)
                {
                    Console.WriteLine(pet);
                }
                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }

        // Print {clinic's name} {room}
        else if (args.Length == 3)
        {
            int room = int.Parse(args[2]);
            Clinic currentClinic = clinics.FirstOrDefault(c => c.Name.Equals(clinicName));
            Console.WriteLine(currentClinic.Print(room));
        }
    }

    private static void Create(string[] args)
    {
        // Create Pet {name} {age} {kind}
        if (args[1].Equals("Pet"))
        {
            string petName = args[2];
            int petAge = int.Parse(args[3]);
            string kind = args[4];

            pets.Add(new Pet(petName, petAge, kind));
        }

        // Create Clinic {name} {rooms}
        else if (args[1].Equals("Clinic"))
        {
            string clinicName = args[2];
            int roomsCount = int.Parse(args[3]);

            try
            {
                clinics.Add(new Clinic(clinicName, roomsCount));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


