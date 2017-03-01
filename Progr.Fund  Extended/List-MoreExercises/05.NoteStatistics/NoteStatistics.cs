using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var notesValues = new Dictionary<string, double>();
        notesValues.Add("C", 261.63);
        notesValues.Add("C#", 277.18);
        notesValues.Add("D", 293.66);
        notesValues.Add("D#", 311.13);
        notesValues.Add("E", 329.63);
        notesValues.Add("F", 349.23);
        notesValues.Add("F#", 369.99);
        notesValues.Add("G", 392.00);
        notesValues.Add("G#", 415.30);
        notesValues.Add("A", 440.00);
        notesValues.Add("A#", 466.16);
        notesValues.Add("B", 493.88);

        var values = Console.ReadLine().Split().Select(double.Parse).ToList();

        var notes = new List<string>();
        var naturals = new List<string>();
        var sharps = new List<string>();

        for (int i = 0; i < values.Count; i++)
        {
            var name = notesValues.Where(x => x.Value == values[i]).Select(x => x.Key).First();
            if (name.Contains("#"))
            {
                sharps.Add(string.Join(string.Empty, name));
            }
            else
            {
                naturals.Add(string.Join(string.Empty, name));
            }

            notes.Add(string.Join(string.Empty, name));
        }

        Console.WriteLine($"Notes: {string.Join(" ", notes)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

        var naturalSum = GetSum(notesValues, naturals);
        var sharpSum = GetSum(notesValues, sharps);

        var naturalSumResult = naturalSum > 0 ? $"Naturals sum: {naturalSum:f2}" : $"Naturals sum: 0";
        var sharpSumResult = sharpSum > 0 ? $"Sharps sum: {sharpSum:f2}" : $"Sharps sum: 0";
        Console.WriteLine(naturalSumResult);
        Console.WriteLine(sharpSumResult);
    }

    private static double GetSum(Dictionary<string, double> values, List<string> elements)
    {
        double sum = 0.0;
        foreach (var element in elements)
        {
            sum += values[element];
        }

        return sum;
    }
}
