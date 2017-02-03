using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        var peopleScore = new Dictionary<string, List<string>>();

        while (!inputLine.Equals("JOKER"))
        {
            string[] lineArgs = inputLine.Split(':').ToArray();
            string personName = lineArgs[0].Trim();

            List<string> cards = lineArgs[1]
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (!peopleScore.ContainsKey(personName))
            {
                peopleScore.Add(personName, new List<string>());
            }

            peopleScore[personName].AddRange(cards);

            inputLine = Console.ReadLine();
        }

        foreach (var score in peopleScore)
        {
            var peopleHands = score.Value.Distinct().ToList();
            int value = GetValue(peopleHands);
            Console.WriteLine($"{score.Key}: {value}");
        }
    }

    private static int GetValue(List<string> cards)
    {
        int value = 0;

        for (int i = 0; i < cards.Count; i++)
        {
            int faceCardpower = GetFaceCardPower(cards[i].Substring(0, cards[i].Length - 1));
            int suitPower = GetSuitPower(cards[i].Substring(cards[i].Length - 1));

            value += faceCardpower * suitPower;
        }

        return value;
    }

    private static int GetFaceCardPower(string faceCard)
    {
        try
        {
            return int.Parse(faceCard);
        }
        catch (Exception)
        {
            switch (faceCard)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 0;
            }
        }
    }

    private static int GetSuitPower(string suit)
    {
        switch (suit)
        {
            case "S":
                return 4;
            case "H":
                return 3;
            case "D":
                return 2;
            case "C":
                return 1;
            default:
                return 0;
        }
    }
}
