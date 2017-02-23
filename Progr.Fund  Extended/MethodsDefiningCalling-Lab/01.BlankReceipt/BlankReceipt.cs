using System;

public class BlankReceipt
{
    public static void Main()
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