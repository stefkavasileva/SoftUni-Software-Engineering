using System;
using System.Collections.Generic;
using System.Linq;

public class MixedPhones
{
    public static void Main()
    {
        var mixedPhoneBook = new SortedDictionary<string, long>();

        while (true)
        {
            var contact = Console.ReadLine();
            if (contact.Equals("Over")) break;

            var contactArgs = contact.Split(':').Select(x => x.Trim()).ToArray();
            bool hasOnlyDigits = contactArgs[0].All(c => char.IsDigit(c));

            var phoneNumber = string.Empty;
            var name = string.Empty;

            if (hasOnlyDigits)
            {
                phoneNumber = contactArgs[0];
                name = contactArgs[1];
            }
            else
            {
                phoneNumber = contactArgs[1];
                name = contactArgs[0];
            }

            if (!mixedPhoneBook.ContainsKey(name))
            {
                mixedPhoneBook.Add(name, 0);
            }

            mixedPhoneBook[name] = long.Parse(phoneNumber);
        }

        foreach (var kvp in mixedPhoneBook)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

