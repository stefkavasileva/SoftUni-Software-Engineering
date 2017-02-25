using System;
using System.Linq;
using System.Text;

public class CharRotation
{
    public static void Main()
    {
        var text = Console.ReadLine().ToCharArray();
        var numbres = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var result = new StringBuilder();

        for (int i = 0; i < numbres.Length; i++)
        {
            var currentNum = numbres[i];

            var charAsInt = currentNum % 2 == 0 ? text[i] - currentNum : text[i] + currentNum;
            result.Append((char)charAsInt);
        }

        Console.WriteLine(result);
    }
}
