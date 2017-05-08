using System;

public class StringLength
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var newtext = text.Substring(0, Math.Min(20, text.Length));

        if (newtext.Length != 20)
        {
            newtext += new string('*', 20 - text.Length);
        }

        Console.WriteLine(newtext);
    }
}

