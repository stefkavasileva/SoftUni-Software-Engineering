using System;
using System.Linq;

public class CommandInterpreter
{
    public static void Main()
    {
        var elements = Console.ReadLine()
            .Split()
            .Where(x => x != string.Empty)
            .Select(x => x.Trim())
            .ToList();

        var comand = Console.ReadLine();

        while (!comand.ToLower().Equals("end"))
        {
            var comandArgs = comand
                .Split()
                .Where(x => x != string.Empty)
                .Select(x => x.Trim())
                .ToArray();

            var action = comandArgs[0];

            if (action.Equals("reverse") || action.Equals("sort"))
            {
                var index = int.Parse(comandArgs[2]);
                var count = int.Parse(comandArgs[4]);

                if (index < 0 || index >= elements.Count || count < 0 || index + count > elements.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    comand = Console.ReadLine();
                    continue;
                }

                var potionOfArray = elements.Skip(index).Take(count).ToList();

                if (action.Equals("sort"))
                {
                    potionOfArray.Sort();
                }
                else
                {
                    potionOfArray.Reverse();
                }

                elements.RemoveRange(index, count);
                elements.InsertRange(index, potionOfArray);
            }
            else
            {
                var count = int.Parse(comandArgs[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    comand = Console.ReadLine();
                    continue;
                }

                count = count % elements.Count;

                if (action.Equals("rollRight"))
                {
                    for (int i = 0; i < count; i++)
                    {
                        var lastNum = elements[elements.Count - 1];
                        elements.RemoveAt(elements.Count - 1);
                        elements.Insert(0, lastNum);
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        var firstNum = elements[0];
                        elements.RemoveAt(0);
                        elements.Add(firstNum);
                    }
                }
            }

            comand = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", elements)}]");
    }
}