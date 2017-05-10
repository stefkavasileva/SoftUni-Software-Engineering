using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var phonebook = new Dictionary<string, string>();

        while (!inputLine.ToLower().Equals("search"))
        {
            var tokens = inputLine.Split('-');
            var name = tokens[0];
            var phone = tokens[1];

            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, string.Empty);
            }

            phonebook[name] = phone;

            inputLine = Console.ReadLine();
        }

        inputLine = Console.ReadLine();

        while (!inputLine.ToLower().Equals("stop"))
        {
            if (phonebook.ContainsKey(inputLine))
            {
                Console.WriteLine($"{inputLine} -> {phonebook[inputLine]}");
            }
            else
            {
                Console.WriteLine($"Contact {inputLine} does not exist.");
            }

            inputLine = Console.ReadLine();
        }
    }
}