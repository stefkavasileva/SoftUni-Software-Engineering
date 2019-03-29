using System;

public class StringsAndObjects
{
    public static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";

        object concatinatedStrings = firstWord + " " + secondWord;

        string result = concatinatedStrings.ToString();

        Console.WriteLine(result);
    }
}
