using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        var firstPower = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        var secondPower = new List<string> { "C", "D", "H", "S" };

        var peopleCards = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("JOKER")) break;

            var token = inputLine.Split(':');
            var personName = token[0].Trim();
            var cards = token[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (!peopleCards.ContainsKey(personName))
            {
                peopleCards.Add(personName, new HashSet<string>());
            }

            cards.ForEach(x => peopleCards[personName].Add(x));
        }

        foreach (var person in peopleCards)
        {
            var score = 0;
            foreach (var card in person.Value)
            {
                var firstValue = firstPower.IndexOf(card.Substring(0, card.Length - 1)) + 2;
                var secondValue = secondPower.IndexOf(card.Substring(card.Length - 1)) + 1;
                score += firstValue * secondValue;
            }

            Console.WriteLine($"{person.Key}: {score}");
        }
    }
}
