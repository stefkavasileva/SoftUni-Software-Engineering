using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractEmails
{
    static void Main(string[] args)
    {
        //75/100
        string [] textItems = Console.ReadLine().TrimEnd('.')
                .Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

        string pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";
        Regex reg = new Regex(pattern);
        foreach (var item in textItems)
        {
            if (reg.IsMatch(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}

