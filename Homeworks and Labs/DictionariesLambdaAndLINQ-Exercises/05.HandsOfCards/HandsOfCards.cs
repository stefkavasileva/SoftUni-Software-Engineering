using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HandsOfCards
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();
        char[] separators = ", ".ToCharArray();
        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("JOKER"))
        {
            string[] inputArgs = inputLine.Split(':');
            string name = inputArgs[0];
            string[] hand = inputArgs[1].Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (!hands.ContainsKey(name))
            {
                hands.Add(name, new List<string>());
            }

            hands[name].AddRange(hand);
            inputLine = Console.ReadLine();
        }


        foreach (var p in hands)
        {
            List<string> cards = p.Value.Distinct().ToList();
            int sum = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                string suitAsStr = cards[i].Substring(cards[i].Length - 1);
                string rankAsStr = cards[i].Substring(0, cards[i].Length - 1);
                int rank = CalRank(rankAsStr);
                int suit = CalSuit(suitAsStr);
                sum += rank * suit;
            }

            Console.WriteLine("{0}: {1}", p.Key, sum);

        }
    }

    private static int CalSuit(string suitAsStr)
    {
        int suit = 0;
        switch (suitAsStr)
        {
            case "S":
                suit = 4;
                break;
            case "H":
                suit = 3;
                break;
            case "D":
                suit = 2;
                break;
            default:
                suit = 1;
                break;
        }
        return suit;
    }

    private static int CalRank(string rankAsStr)
    {
        int rank = 0;

        switch (rankAsStr)
        {
            case "J":
                rank = 11;
                break;
            case "Q":
                rank = 12;
                break;
            case "K":
                rank = 13;
                break;
            case "A":
                rank = 14;
                break;
            default:
                rank = int.Parse(rankAsStr);
                break;
        }
        return rank;
    }
}

