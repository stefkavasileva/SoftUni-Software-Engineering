using System;
using System.Collections.Generic;
using System.Text;

public class Phonebook
{
    public static void Main()
    {
        var phonebook = new Dictionary<string, string>();

        var input = Console.ReadLine();
        while (!input.Equals("search"))
        {
            var tokens = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            var name = tokens[0];
            var phoneNumber = tokens[1];

            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name,string.Empty);
            }

            phonebook[name] = phoneNumber;
            input = Console.ReadLine();
        }

        var sb = new StringBuilder();

        var search = Console.ReadLine();
        while (!search.Equals("stop"))
        {
            if (phonebook.ContainsKey(search))
            {
                sb.AppendLine($"{search} -> {phonebook[search]}");
            }
            else
            {
                sb.AppendLine($"Contact {search} does not exist.");
            }

            search = Console.ReadLine();
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}