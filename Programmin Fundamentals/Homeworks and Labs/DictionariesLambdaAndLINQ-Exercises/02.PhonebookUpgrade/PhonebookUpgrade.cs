using System;
using System.Collections.Generic;
using System.Linq;

public class PhonebookUpgrade
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        var phonebook = new SortedDictionary<string, string>();

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
            else if (comandArgs[0].Equals("S"))
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
            else
            {
                foreach (var contact in phonebook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }

            inputLine = Console.ReadLine();
        }
    }
}
