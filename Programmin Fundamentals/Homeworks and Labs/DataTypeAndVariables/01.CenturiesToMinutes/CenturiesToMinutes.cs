using System;

public class CenturiesToMinutes
{
    public static void Main()
    {
        Console.Write("Centuries = ");
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        long hours = 24 * days;
        long minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
