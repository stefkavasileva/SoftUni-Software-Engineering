using System;
using System.Linq;

public class SortArrayOfStrings
{
    public static void Main()
    {
        var textElements = Console.ReadLine().Split().ToArray();

        for (int i = 0; i < textElements.Length; i++)
        {
            for (int j = i + 1; j < textElements.Length; j++)
            {
                var firstElement = textElements[i];
                var secondElement = textElements[j];
                var firstIsSmaller = firstElement.CompareTo(secondElement) == -1 ? true : false;
                if (!firstIsSmaller)
                { 
                    textElements[i] = secondElement;
                    textElements[j] = firstElement;
                }
            }
        }

        Console.WriteLine(string.Join(" ",textElements));
    }
}
