using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PokerStraight
{
    static void Main(string[] args)
    {
        int targetWeight = int.Parse(Console.ReadLine());
        int[] faceCard = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] suitCards = { 1, 2, 3, 4 };
        int weight = 0;
        int counter = 0;

        for (int i = 0; i < faceCard.Length - 4; i++)
        {
            for (int s1 = 0; s1 < 4; s1++)
            {
                for (int s2 = 0; s2 < 4; s2++)
                {
                    for (int s3 = 0; s3 < 4; s3++)
                    {
                        for (int s4 = 0; s4 < 4; s4++)
                        {
                            for (int s5 = 0; s5 < 4; s5++)
                            {
                                weight = (10 * faceCard[i] + suitCards[s1]) + (20 * faceCard[i + 1] + suitCards[s2])
                                   + (30 * faceCard[i + 2] + suitCards[s3]) + (40 * faceCard[i + 3] + suitCards[s4])
                                   + (50 * faceCard[i + 4] + suitCards[s5]);

                                if (weight == targetWeight)
                                {
                                    counter++;

                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(counter);
    }
}

