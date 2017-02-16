using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var pattren = @"^[A-Z]{1}[a-z]+ [A-Z][a-z]+$";

        var names = Console.ReadLine().Split(',');

        foreach (var name in names)
        {
            Regex reg = new Regex(pattren);

            if (reg.IsMatch(name.Trim()))
            {
                Console.WriteLine(name.Trim());
            }
        }
    }
}
