using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        var reg = new Regex(@"^[A-Z]{1}[a-z]+ [A-Z][a-z]+$");

        var name = Console.ReadLine();

        while (!name.Equals("end"))
        {

            if (reg.IsMatch(name.Trim()))
            {
                Console.WriteLine(name.Trim());
            }

            name = Console.ReadLine();
        }
    }
}

