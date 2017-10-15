using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NumberWars
{
    public class Startup
    {
        public static List<string> NaturalSort(List<string> list)
        {
            int maxLen = list.Select(s => s.Length).Max();
            Func<string, char> PaddingChar = s => char.IsDigit(s[0]) ? ' ' : char.MaxValue;

            return list
                .Select(s =>
                    new
                    {
                        OrgStr = s,
                        SortStr = Regex.Replace(s, @"(\d+)|(\D+)", m => m.Value.PadLeft(maxLen, PaddingChar(m.Value)))
                    })
                .OrderBy(x => x.SortStr)
                .Select(x => x.OrgStr).ToList();
        }

        public static void Main()
        {
            var firstCardsAsStr = Console.ReadLine();
            var secondCardsAsStr = Console.ReadLine();

            if (firstCardsAsStr.Equals(secondCardsAsStr))
            {
                Console.WriteLine("Draw after 1 turns");
                return;
            }

            var firstPlayerCards = new Queue<string>(firstCardsAsStr
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var secondPlayerCards = new Queue<string>(secondCardsAsStr
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            var turns = 0;
            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0 && turns < 1000000)
            {
                var firstCard = firstPlayerCards.Dequeue();
                var secondCard = secondPlayerCards.Dequeue();
                var firstScore = int.Parse(new string(firstCard.Where(x => char.IsDigit(x)).ToArray()));
                var secondScore = int.Parse(new string(secondCard.Where(x => char.IsDigit(x)).ToArray()));

                if (firstScore > secondScore)
                {
                    var cardsAsStr = new List<string> { firstCard, secondCard };
                    cardsAsStr = NaturalSort(cardsAsStr);
                    cardsAsStr.Reverse();
                    firstPlayerCards.Enqueue(cardsAsStr[0]);
                    firstPlayerCards.Enqueue(cardsAsStr[1]);
                    turns++;
                    continue;
                }

                if (secondScore > firstScore)
                {
                    var cardsAsStr = new List<string> { firstCard, secondCard };
                    cardsAsStr = NaturalSort(cardsAsStr);
                    cardsAsStr.Reverse();
                    secondPlayerCards.Enqueue(cardsAsStr[0]);
                    secondPlayerCards.Enqueue(cardsAsStr[1]);
                    turns++;
                    continue;
                }

                var firstCardsScore = 0L;
                var secondCardsScore = 0L;
                var cards = new List<string>();
                cards.Add(firstCard);
                cards.Add(secondCard);

                while (firstCardsScore == secondCardsScore)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (firstPlayerCards.Any())
                        {
                            var currentFirstCard = firstPlayerCards.Peek();
                            cards.Add(firstPlayerCards.Dequeue());
                            firstCardsScore += GetScore(currentFirstCard.ToLower());
                        }
                        else
                        {
                            Console.WriteLine($"Second player wins after {turns} turns");
                            return;
                        }

                        if (secondPlayerCards.Any())
                        {
                            var currentSecondCard = secondPlayerCards.Peek();
                            cards.Add(secondPlayerCards.Dequeue());
                            secondCardsScore += GetScore(currentSecondCard.ToLower());
                        }
                        else
                        {
                            Console.WriteLine($"First player wins after {turns} turns");
                            return;
                        }
                    }

                    if (firstCardsScore > secondCardsScore)
                    {
                        cards = NaturalSort(cards);
                        cards.Reverse();
                        for (int i = 0; i < cards.Count; i++)
                        {
                            firstPlayerCards.Enqueue(cards[i]);
                        }

                    }
                    else if (secondCardsScore > firstCardsScore)
                    {
                        cards = NaturalSort(cards);
                        cards.Reverse();
                        for (int i = 0; i < cards.Count; i++)
                        {
                            secondPlayerCards.Enqueue(cards[i]);
                        }
                    }
                }

                turns++;
            }

            if (!firstPlayerCards.Any())
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
            else if (!secondPlayerCards.Any())
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else
            {
                Console.WriteLine($"Draw after {turns} turns");
            }
        }

        private static long GetScore(string card)
        {
            var sum = 0l;
            for (int i = 0; i < card.Length; i++)
            {
                if (char.IsLetter(card[i]))
                {
                    sum += card[i] - 97;
                }
            }

            return sum;
        }
    }
}
