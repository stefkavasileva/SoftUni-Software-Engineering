using System;
using System.Linq;

public class PredicateForNames
{
    public static void Main()
    {
        var length = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split().ToList();

        var result = names.FindAll(delegate (string name)
       {
           return name.Length <= length;
       });

        Console.WriteLine(string.Join(Environment.NewLine,result));
    }
}

