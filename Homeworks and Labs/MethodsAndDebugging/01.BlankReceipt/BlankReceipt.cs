using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BlankReceipt
{
    static void Main(string[] args)
    {
        PrintReceipt();
    }

    public static void PrintReceipt()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    private static void PrintFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("\u00A9 SoftUni");
    }

    private static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
}

