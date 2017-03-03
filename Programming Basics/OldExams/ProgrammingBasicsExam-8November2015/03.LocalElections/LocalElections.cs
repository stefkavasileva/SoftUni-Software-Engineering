using System;

public class LocalElections
{
    public static void Main()
    {
        int candidateList = int.Parse(Console.ReadLine());
        int elector = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine().ToUpper();

        for (int i = 1; i <= candidateList; i++)
        {
            string num = string.Empty;
            if (i > 9)
            {
                num = i.ToString();
            }
            else
            {
                num = "0" + i;
            }

            if (i == elector && symbol == "X")
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                Console.WriteLine("...|.\\./.|...");
                Console.WriteLine("{0}.|..{1}..|...", num, symbol);
                Console.WriteLine("...|./.\\.|...");
                Console.WriteLine("...+-----+...");

            }
            else if (i == elector && symbol == "V")
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                Console.WriteLine("...|\\.../|...");
                Console.WriteLine("{0}.|.\\./.|...", num);
                Console.WriteLine("...|..{0}..|...", symbol);
                Console.WriteLine("...+-----+...");
            }
            else
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");
                Console.WriteLine("...|.....|...");
                Console.WriteLine("{0}.|.....|...", num);
                Console.WriteLine("...|.....|...");
                Console.WriteLine("...+-----+...");
            }
        }

        Console.WriteLine(".............");
    }
}
