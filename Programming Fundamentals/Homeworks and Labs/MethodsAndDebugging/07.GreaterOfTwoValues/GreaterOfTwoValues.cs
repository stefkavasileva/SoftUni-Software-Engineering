using System;

public class GreaterOfTwoValues
{
    public static void Main()
    {
        string type = Console.ReadLine().ToLower();
        string firstVar = Console.ReadLine();
        string secondVar = Console.ReadLine();

        if (type.Equals("int"))
        {
            int firstNum = int.Parse(firstVar);
            int secondNum = int.Parse(secondVar);
            int result = GetMax(firstNum, secondNum);

            Console.WriteLine(result);
            return;
        }

        if (type.Equals("char"))
        {
            char firstChar = char.Parse(firstVar);
            char secondChar = char.Parse(secondVar);
            char result = GetMax(firstChar, secondChar);

            Console.WriteLine(result);
            return;
        }

        if (type.Equals("string"))
        {
            string result = GetMax(firstVar, secondVar);

            Console.WriteLine(result);
            return;
        }
    }

    public static int GetMax(int first, int second)
    {
        int maxNum = Math.Max(first, second);
        return maxNum;
    }

    public static char GetMax(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    public static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
