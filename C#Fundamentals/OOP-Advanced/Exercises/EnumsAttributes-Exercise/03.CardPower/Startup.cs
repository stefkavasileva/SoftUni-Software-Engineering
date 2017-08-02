using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        //========5======//
        //var firstCard = GenerateCard(Console.ReadLine(), Console.ReadLine());
        //var secondCard = GenerateCard(Console.ReadLine(), Console.ReadLine());

        //var result = firstCard.CompareTo(secondCard) > 0 ? firstCard : secondCard;

        //Console.WriteLine(result);
        //===================================//

        //=============6============//
        //var enumType = Console.ReadLine();

        //Type currentType = null;

        //if (enumType.Equals("Rank"))
        //{
        //    currentType = typeof(Rank);
        //}
        //else if (enumType.Equals("Suit"))
        //{
        //    currentType = typeof(Suit);
        //}

        //foreach (object attribute in currentType.GetCustomAttributes(false))
        //{
        //    Console.WriteLine(attribute);
        //}
        //=============================///

        //==============7==============//
        //foreach (var suit in Enum.GetValues(typeof(Suit)))
        //{
        //    foreach (var rank in Enum.GetValues(typeof(Rank)))
        //    {
        //        Console.WriteLine($"{rank} of {suit}");
        //    }
        //}
        //==================================//

        //20/100===================================???????////
        var allCards = GenerateCards();
        var firstPlayer = new Player(Console.ReadLine());
        var secondPlayer = new Player(Console.ReadLine());

        firstPlayer.Cards = new List<Card>();
        secondPlayer.Cards = new List<Card>();

        while (firstPlayer.Cards.Count < 5 || secondPlayer.Cards.Count < 5)
        {
            var cardArgs = Console.ReadLine().Split();
            var currentCard = new Card();

            try
            {
                currentCard = GenerateCard(cardArgs[0], cardArgs[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            if (firstPlayer.Cards.Count < 5)
            {
                AddCard(currentCard, firstPlayer, allCards);
            }
            else
            {
                AddCard(currentCard, secondPlayer, allCards);
            }
        }

        var winner = GetWinner(firstPlayer, secondPlayer);
        Console.WriteLine(winner);
    }

    private static IList<Card> GenerateCards()
    {
        List<Card> deck = new List<Card>();
        Array suits = Enum.GetNames(typeof(Suit));
        Array ranks = Enum.GetNames(typeof(Rank));

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card currentCard = GenerateCard(rank, suit);
                deck.Add(currentCard);
            }
        }

        return deck;
    }

    private static string GetWinner(Player firstPlayer, Player secondPlayer)
    {
        var firstPlayerMaxCard = firstPlayer.Cards.Max();
        var secondPlayerMaxCard = secondPlayer.Cards.Max();


        if (firstPlayerMaxCard.CompareTo(secondPlayerMaxCard) > 0)
        {
            return $"{firstPlayer.Name} wins with {firstPlayerMaxCard.Rank} of {firstPlayerMaxCard.Suit}.";
        }

        if (secondPlayerMaxCard.CompareTo(firstPlayerMaxCard) > 0)
        {
            return $"{secondPlayer.Name} wins with {secondPlayerMaxCard.Rank} of {secondPlayerMaxCard.Suit}.";
        }

        return "No winner";
    }

    private static void AddCard(Card currentCard, Player player, IList<Card> allCards)
    {
        if (!allCards.Any(x => x.Rank.Equals(currentCard.Rank) && x.Suit.Equals(currentCard.Suit)))
        {
            Console.WriteLine("Card is not in the deck.");
        }
        else
        {
            player.Cards.Add(currentCard);
            allCards.Remove(allCards.First(x => x.Rank.Equals(currentCard.Rank) && x.Suit.Equals(currentCard.Suit)));
        }
    }

    private static Card GenerateCard(string rankAsStr, string suitAsStr)
    {
        try
        {
            var rank = (Rank)Enum.Parse(typeof(Rank), rankAsStr, false);
            var suit = (Suit)Enum.Parse(typeof(Suit), suitAsStr, false);

            return new Card(rank, suit);
        }
        catch (Exception)
        {
            throw new ArgumentException("No such card exists.");
        }
    }
}

