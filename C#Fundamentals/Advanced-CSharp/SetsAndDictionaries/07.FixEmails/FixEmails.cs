using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        var contacts = new Dictionary<string, string>();

        while (true)
        {
            var name = Console.ReadLine();
            if (name.Equals("stop")) break;
            var email = Console.ReadLine();

            if(!email.Contains(".uk") && !email.Contains(".us"))
            {
                if (contacts.ContainsKey(name))
                {
                    contacts.Add(name, string.Empty);
                }

                contacts[name] = email;
            }
        }

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }
}