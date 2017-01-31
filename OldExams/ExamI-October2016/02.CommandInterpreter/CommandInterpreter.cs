using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    public static void Main()
    {
        List<string> inputElements = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(x => x.Trim())
           .ToList();

        string comand = Console.ReadLine();
        while (!comand.Equals("end"))
        {
            string[] comandArgs = comand.Split().Select(x => x.Trim()).ToArray();

            if (comandArgs[0].Equals("reverse") || comandArgs[0].Equals("sort"))
            {
                int startIndex = int.Parse(comandArgs[2]);
                int count = int.Parse(comandArgs[4]);

                if (startIndex < 0 || startIndex >= inputElements.Count || count < 0 || startIndex + count > inputElements.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    comand = Console.ReadLine();
                    continue;
                }

                List<string> elements = inputElements.Skip(startIndex).Take(count).ToList();
                inputElements.RemoveRange(startIndex, count);

                if (comandArgs[0].Equals("reverse"))
                {
                    elements.Reverse();
                }
                else
                {
                    elements.Sort();
                }

                inputElements.InsertRange(startIndex, elements);
            }
            else
            {
                int count = int.Parse(comandArgs[1]) % inputElements.Count();

                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    comand = Console.ReadLine();
                    continue;
                }

                if (comandArgs[0].Equals("rollLeft"))
                {
                    for (int i = 0; i < count; i++)
                    {
                        inputElements.Add(inputElements[0]);
                        inputElements.RemoveAt(0);
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        inputElements.Insert(0, inputElements[inputElements.Count - 1]);
                        inputElements.RemoveAt(inputElements.Count - 1);
                    }
                }
            }

            comand = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", inputElements));
    }
}
