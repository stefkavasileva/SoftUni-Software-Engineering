using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PhonebookUpgrade
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        var phonebook = new SortedDictionary<string, string>();

        while (!inputLine.Equals("END"))
        {
            string[] comandArgs = inputLine.Split().ToArray();
            string action = comandArgs[0];        
            if (action.Equals("A"))
            {
                AddEntryToPhonebook(phonebook, comandArgs);
            }
            else if (action.Equals("S"))
            {
                SearchByGivenName(phonebook, comandArgs);
            }
            else if (action.Equals("ListAll"))
            {
                PrintPhonebook(phonebook);
            }

            inputLine = Console.ReadLine();
        }
    }

    private static void PrintPhonebook(SortedDictionary<string, string> phonebook)
    {
        foreach (var contact in phonebook)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }

    private static void SearchByGivenName(SortedDictionary<string, string> phonebook, string[] comandArgs)
    {
        string name = comandArgs[1];
        if (phonebook.ContainsKey(name))
        {
            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
        }
        else
        {
            Console.WriteLine("Contact {0} does not exist.", name);
        }
    }

    private static void AddEntryToPhonebook(SortedDictionary<string, string> phonebook, string[] comandArgs)
    {
        string name = comandArgs[1];
        string phoneNumber = comandArgs[2];
        phonebook[name] = phoneNumber;
    }
}

