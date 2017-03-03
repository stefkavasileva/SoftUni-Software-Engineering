using System;

public class BasketBattle
{
    public static void Main()
    {
        string firstPlayerName = Console.ReadLine();
        int numOfRounds = int.Parse(Console.ReadLine());

        int firstPlayerScore = 0;
        int secondPlayerScore = 0;
        bool isTimeToSwitch = false;
        string nameOfWinner = string.Empty;
        int round = 0;
        int pointsLostPlayer = 0;
        bool haveAWinner = false;

        for (int i = 0; i < numOfRounds; i++)
        {
            int points1 = int.Parse(Console.ReadLine());
            bool isSuccessful1 = Console.ReadLine().Equals("success") ? true : false;

            if (!isTimeToSwitch && isSuccessful1 && firstPlayerScore + points1 == 500)
            {
                nameOfWinner = firstPlayerName;
                round = i + 1;
                pointsLostPlayer = secondPlayerScore;
                haveAWinner = true;
                break;
            }

            if (isTimeToSwitch && isSuccessful1 && secondPlayerScore + points1 == 500)
            {
                nameOfWinner = firstPlayerName.Equals("Simeon") ? "Nakov" : "Simeon";
                round = i + 1;
                pointsLostPlayer = firstPlayerScore;
                haveAWinner = true;
                break;
            }

            int points2 = int.Parse(Console.ReadLine());
            bool isSuccessful2 = Console.ReadLine().Equals("success") ? true : false;

            if (isTimeToSwitch)
            {
                if (isSuccessful2 && firstPlayerScore + points2 <= 500)
                {
                    firstPlayerScore += points2;
                }

                if (isSuccessful1 && secondPlayerScore + points1 <= 500)
                {
                    secondPlayerScore += points1;
                }
            }
            else
            {
                if (isSuccessful1 && firstPlayerScore + points1 <= 500)
                {
                    firstPlayerScore += points1;
                }

                if (isSuccessful2 && secondPlayerScore + points2 < 500)
                {
                    secondPlayerScore += points2;
                }

            }

            if (firstPlayerScore == 500)
            {
                nameOfWinner = firstPlayerName;
                round = i + 1;
                pointsLostPlayer = secondPlayerScore;
                break;
            }

            if (secondPlayerScore == 500)
            {
                nameOfWinner = firstPlayerName.Equals("Simeon") ? "Nakov" : "Simeon";
                round = i + 1;
                pointsLostPlayer = firstPlayerScore;
                break;
            }

            isTimeToSwitch = !isTimeToSwitch;
        }


        if (firstPlayerScore == 500 || secondPlayerScore == 500 || haveAWinner)
        {
            Console.WriteLine(nameOfWinner);
            Console.WriteLine(round);
            Console.WriteLine(pointsLostPlayer);
        }
        else if (firstPlayerScore == secondPlayerScore)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(firstPlayerScore);
        }
        else
        {
            if (firstPlayerScore > secondPlayerScore)
            {
                Console.WriteLine(firstPlayerName);
                Console.WriteLine(firstPlayerScore - secondPlayerScore);
            }
            else
            {
                Console.WriteLine(firstPlayerName.Equals("Simeon") ? "Nakov" : "Simeon");
                Console.WriteLine(secondPlayerScore - firstPlayerScore);
            }
        }
    }
}
