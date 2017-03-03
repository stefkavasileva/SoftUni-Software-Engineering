using System;

public class ChessboardGame
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char[] inputLetters = Console.ReadLine().ToCharArray();

        long blackPoints = 0;
        long whitePoints = 0;

        for (int i = 0; i < inputLetters.Length; i++)
        {
            if (i >= size * size)
            {
                break;
            }

            if (i % 2 == 0)
            {
                if (char.IsLower(inputLetters[i]) || char.IsDigit(inputLetters[i]))
                {
                    blackPoints += inputLetters[i];
                }
                else if (char.IsUpper(inputLetters[i]))
                {
                    whitePoints += inputLetters[i];
                }
            }
            else
            {
                if (char.IsLower(inputLetters[i]) || char.IsDigit(inputLetters[i]))
                {
                    whitePoints += inputLetters[i];
                }
                else if (char.IsUpper(inputLetters[i]))
                {
                    blackPoints += inputLetters[i];
                }
            }
        }

        if (blackPoints > whitePoints)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackPoints - whitePoints);
        }
        else if (whitePoints > blackPoints)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whitePoints - blackPoints);
        }
        else
        {
            Console.WriteLine("Equal result: {0}", blackPoints);
        }
    }
}
