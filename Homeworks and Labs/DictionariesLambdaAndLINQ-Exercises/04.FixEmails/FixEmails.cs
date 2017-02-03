using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        var contacts = new Dictionary<string, string>();

        while (true)
        {
            string name = Console.ReadLine();

            if (name.Equals("stop")) break;

            string email = Console.ReadLine();

            string domain = email.Substring(email.Length - 2).ToLower();

            if (!domain.Equals("us") && !domain.Equals("uk"))
            {
                if (!contacts.ContainsKey(name))
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