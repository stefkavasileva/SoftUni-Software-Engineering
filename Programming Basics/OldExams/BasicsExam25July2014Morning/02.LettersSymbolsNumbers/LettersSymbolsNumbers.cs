using System;

public class LettersSymbolsNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int letterSum = 0;
        int numberSum = 0;
        int symbolSum = 0;

        for (int i = 0; i < n; i++)
        {
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                if (char.IsDigit(input[j]))
                {
                    numberSum += (int)char.GetNumericValue(input[j]) * 20;
                }
                else if (char.IsLetter(input[j]))
                {
                    letterSum += (input[j] - 96) * 10;
                }
                else if (input[j] == ' ' || input[j] == '\t' || input[j] == '\r' || input[j] == '\n')
                {
                    continue;
                }
                else
                {
                    symbolSum += 200;
                }
            }
        }

        Console.WriteLine(letterSum);
        Console.WriteLine(numberSum);
        Console.WriteLine(symbolSum);
    }
}
