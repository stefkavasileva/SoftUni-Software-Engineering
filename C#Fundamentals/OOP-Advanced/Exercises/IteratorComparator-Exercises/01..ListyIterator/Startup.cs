using System;
using System.Linq;
using System.Text;

public class Startup
{
    public static void Main()
    {
        var collection = new ListyIterator<string>();

        var inputCommand = Console.ReadLine();
        while (!inputCommand.Equals("END"))
        {
            var lineArgs = inputCommand.Split();
            try
            {
                if (lineArgs[0].Equals("Create"))
                {
                    collection.Create(lineArgs.Skip(1).ToList());
                }
                else if (lineArgs[0].Equals("Move"))
                {
                    Console.WriteLine(collection.Move());
                }
                else if (lineArgs[0].Equals("Print"))
                {
                    collection.Print();
                }
                else if (lineArgs[0].Equals("HasNext"))
                {
                    Console.WriteLine(collection.HasNext());
                }
                else if (lineArgs[0].Equals("PrintAll"))
                {
                    Console.WriteLine(collection.PrintAll());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            inputCommand = Console.ReadLine();
        }
    }
}
