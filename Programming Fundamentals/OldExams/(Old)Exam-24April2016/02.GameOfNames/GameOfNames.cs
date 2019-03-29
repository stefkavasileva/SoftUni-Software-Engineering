using System;

public class GameOfNames
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int score = 0;
        int bestScore = int.MinValue;
        string nameOfWinner = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            int initialScore = int.Parse(Console.ReadLine());
            score += initialScore;
            for (int j = 0; j < name.Length; j++)
            {
                if (name[j] % 2 == 0)
                {
                    score += name[j];
                }
                else
                {
                    score -= name[j];
                }
            }

            if (score > bestScore)
            {
                bestScore = score;
                nameOfWinner = name;
            }

            score = 0;
        }

        Console.WriteLine("The winner is {0} - {1} points", nameOfWinner, bestScore);
    }
}
