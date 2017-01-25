using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HelloName
{
    static void Main(string[] args)
    {
        string personName = Console.ReadLine();
        PrintGreeting(personName);
    }

    private static void PrintGreeting(string personName)
    {
        Console.WriteLine($"Hello, {personName}!");
    }
}

