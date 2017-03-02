using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gambling
{
    static void Main(string[] args)
    {
        decimal amountOfCash = decimal.Parse(Console.ReadLine());
        string[] cardsHouse = Console.ReadLine().Split();

        decimal weightHouse = 0;
        foreach (var card in cardsHouse)
        {
            switch (card)
            {
                case "A":
                    weightHouse += 14;
                    break;
                case "J":
                    weightHouse += 11;
                    break;
                case "Q":
                    weightHouse += 12;
                    break;
                case "K":
                    weightHouse += 13;
                    break;
                default:
                    weightHouse += int.Parse(card);
                    break;
            }
        }

        int totalHands = 0;
        int strongerHands = 0;

        for (int c1 = 2; c1 <= 14; c1++)
        {
            for (int c2 = 2; c2 <= 14; c2++)
            {
                for (int c3 = 2; c3 <= 14; c3++)
                {
                    for (int c4 = 2; c4 <= 14; c4++)
                    {
                        if (c1 + c2 + c3 + c4 > weightHouse)
                        {
                            strongerHands++;
                        }

                        totalHands++;
                    }
                }
            }
        }

        decimal probabilityOfWin = (decimal)strongerHands / totalHands;

        if (probabilityOfWin < 0.50m)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }

        decimal expextedWinning = probabilityOfWin * 2 * amountOfCash;
        Console.WriteLine("{0:f2}", expextedWinning);
    }
}

