using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AMinerTask
{
    static void Main(string[] args)
    {
        Dictionary<string, int> resourses = new Dictionary<string, int>();
        int counter = 0;
        string key = string.Empty;
        string input = Console.ReadLine();

        while (!input.Equals("stop"))
        {

            if (counter % 2 == 0)
            {
                try
                {
                    resourses.Add(input, 0);
                    key = input;
                }
                catch (Exception)
                {
                    key = input;
                }

            }
            else
            {
                resourses[key] += int.Parse(input);
            }

            counter++;

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> resours in resourses)
        {
            Console.WriteLine("{0} -> {1}", resours.Key, resours.Value);
        }
    }
}

