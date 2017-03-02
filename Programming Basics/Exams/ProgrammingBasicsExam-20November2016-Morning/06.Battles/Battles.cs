using System;

public class Battles
{
    public static void Main(string[] args)
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());

        int stopNum = int.Parse(Console.ReadLine());
        int counter = 1;

        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int j = 1; j <= secondPlayer; j++)
            {
                if (counter == stopNum)
                {
                    Console.Write($"({i} <-> {j}) ");
                    return;
                }

                Console.Write($"({i} <-> {j}) ");
                counter++;
            }
        }
    }
}
