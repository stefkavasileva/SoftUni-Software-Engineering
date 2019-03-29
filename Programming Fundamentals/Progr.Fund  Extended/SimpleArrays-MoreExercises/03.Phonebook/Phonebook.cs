using System;
using System.Linq;
using System.Text;

public class Phonebook
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().ToArray();
        var contacts = Console.ReadLine().Split().ToList();

        var result = new StringBuilder();

        var name = Console.ReadLine();
        while (!name.Equals("done"))
        {
            var index = contacts.IndexOf(name);
            result.AppendLine($"{name} -> {numbers[index]}");
            name = Console.ReadLine();
        }

        Console.Write(result);
    }
}
