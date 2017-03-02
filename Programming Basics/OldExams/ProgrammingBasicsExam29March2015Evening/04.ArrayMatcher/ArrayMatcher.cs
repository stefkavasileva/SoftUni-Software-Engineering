using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayMatcher
{
    static void Main(string[] args)
    {
        string[] inputArrsArgs = Console.ReadLine().Split('\\').ToArray();
        string str1 = inputArrsArgs[0];
        string str2 = inputArrsArgs[1];
        string comand = inputArrsArgs[2].ToLower();

        List<char> result = new List<char>();

        if (comand.Equals("join"))
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str2.Contains(str1[i]))
                {
                    result.Add(str1[i]);
                }
            }
        }
        else if (comand.Equals("left exclude"))
        {
            for (int i = 0; i < str2.Length; i++)
            {
                if (!str1.Contains(str2[i]))
                {
                    result.Add(str2[i]);
                }
            }
        }
        else if (comand.Equals("right exclude"))
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (!str2.Contains(str1[i]))
                {
                    result.Add(str1[i]);
                }
            }
        }

        result.Sort();
        Console.WriteLine(string.Join("", result));
    }
}

