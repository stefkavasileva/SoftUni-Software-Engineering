using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicExchangeableWords
{
    static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine().Split().ToArray();
        string firstStr = inputLine[0];
        string secondStr = inputLine[1];

        Dictionary<char, char> chars = new Dictionary<char, char>();

        bool isEquals = IsExchangeable(firstStr, secondStr, chars);

        Console.WriteLine(isEquals.ToString().ToLower());
    }

    private static bool IsExchangeable(string firstStr, string secondStr, Dictionary<char, char> chars)
    {
        bool isEquals = true;
        for (int i = 0; i < firstStr.Length; i++)
        {
            if (!chars.ContainsKey(firstStr[i]))
            {
                chars.Add(firstStr[i], secondStr[i]);
            }
            else
            {
                if (!chars.ContainsValue(secondStr[i]))
                {
                    isEquals = false;
                }
            }
        }

        return isEquals;
    }
}

