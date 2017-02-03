﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        string[] names = Console.ReadLine()
           .Split(',')
           .Select(n => n.Trim())
           .ToArray();

        Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();

        for (int i = 0; i < names.Length; i++)
        {
            string currentName = names[i];
            string healthSymbolsPattern = @"([^\d\+\-\*\/\.])";
            Regex reg = new Regex(healthSymbolsPattern);
            MatchCollection matches = reg.Matches(currentName);

            int health = GetHealth(matches);

            string numbersPattern = @"(-*\d+\.*\d*)";
            reg = new Regex(numbersPattern);
            matches = reg.Matches(currentName);

            double[] numbers = new double[matches.Count];
            GetNumbers(matches, numbers);

            string symbols = TakeSymbols(names, i, currentName);

            double damage = numbers.Sum();

            damage = AlterDamage(symbols, damage);

            if (!demons.ContainsKey(currentName))
            {
                demons.Add(currentName, new List<double>());
            }

            demons[currentName].Add(health);
            demons[currentName].Add(damage);
        }

        foreach (var demon in demons.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
        }
    }

    private static double AlterDamage(string symbols, double damage)
    {
        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == '*')
            {
                damage *= 2;
            }
            else
            {
                damage /= 2;
            }
        }

        return damage;
    }

    private static string TakeSymbols(string[] names, int i, string currentName)
    {
        string symbols = string.Empty;
        for (int j = 0; j < currentName.Length; j++)
        {
            if (currentName[j] == '*' || currentName[j] == '/')
            {
                symbols += currentName[j];
            }
        }

        return symbols;
    }

    private static int GetHealth(MatchCollection matches)
    {
        int health = 0;
        for (int j = 0; j < matches.Count; j++)
        {
            health += char.Parse(matches[j].Value);
        }

        return health;
    }

    private static void GetNumbers(MatchCollection matches, double[] numbers)
    {
        for (int j = 0; j < matches.Count; j++)
        {
            numbers[j] = double.Parse(matches[j].Groups[1].Value);
        }
    }
}