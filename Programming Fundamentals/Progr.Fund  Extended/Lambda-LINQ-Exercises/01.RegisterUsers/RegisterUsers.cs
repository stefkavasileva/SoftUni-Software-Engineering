using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class RegisterUsers
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var registeredUsers = new Dictionary<string, DateTime>();
        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine
                .Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = tokens[0];
            var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (!registeredUsers.ContainsKey(name))
            {
                registeredUsers.Add(name, new DateTime());
            }

            registeredUsers[name] = date;

            inputLine = Console.ReadLine();
        }

        var result = registeredUsers
            .Reverse()
            .OrderBy(u => u.Value)
            .Take(5)
            .OrderByDescending(u => u.Value)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys;

        Console.Write(string.Join(Environment.NewLine, result));    
    }
}
