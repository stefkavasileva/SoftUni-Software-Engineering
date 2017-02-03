using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        var phonebook = new Dictionary<string, string>();

        while (!inputLine.Equals("END"))
        {
            string[] comandArgs = inputLine.Split().ToArray();

            if (comandArgs[0].Equals("A"))
            {
                string name = comandArgs[1];
                string phoneNumber = comandArgs[2];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, string.Empty);
                }

                phonebook[name] = phoneNumber;
            }
            else
            {
                string name = comandArgs[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }

            inputLine = Console.ReadLine();
        }
    }
}