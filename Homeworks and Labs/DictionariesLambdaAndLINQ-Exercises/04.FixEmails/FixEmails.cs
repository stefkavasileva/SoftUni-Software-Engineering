using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FixEmails
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        int counter = 0;
        string name = string.Empty;

        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("stop"))
        {
            if (counter % 2 == 0)
            {
                contacts[inputLine] = string.Empty;
                name = inputLine;
            }
            else
            {
                contacts[name] = inputLine;
            }
            counter++;
            inputLine = Console.ReadLine();
        }

        foreach (KeyValuePair<string, string> c in contacts)
        {
            string[] emailArgs = c.Value.ToLower().Split('.');
            string domain = emailArgs[1];
            if (!domain.Equals("us") && !domain.Equals("uk"))
            {
                Console.WriteLine("{0} -> {1}", c.Key, c.Value);
            }
        }
    }
}

