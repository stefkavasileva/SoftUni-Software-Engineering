using System;
using System.Collections.Generic;
using System.Linq;

public class TheFootballStatistician
{
    public static void Main()
    {
        //88/100
        decimal payment = decimal.Parse(Console.ReadLine());
        string matchResult = Console.ReadLine();

        SortedDictionary<string, int> teamPoints = new SortedDictionary<string, int>();
        int matchCount = 0;

        while (!matchResult.Equals("End of the league."))
        {
            string[] matchArgs = matchResult.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string team1 = matchArgs[0];
            string team2 = matchArgs[2];
            char result = char.Parse(matchArgs[1]);

            if (!teamPoints.ContainsKey(team1))
            {
                teamPoints.Add(team1, 0);
            }

            if (!teamPoints.ContainsKey(team2))
            {
                teamPoints.Add(team2, 0);
            }

            if (char.IsLetter(result))
            {
                teamPoints[team1] += 1;
                teamPoints[team2] += 1;
            }
            else if (result.Equals('1'))
            {
                teamPoints[team1] += 3;
            }
            else
            {
                teamPoints[team2] += 3;
            }

            matchCount++;
            matchResult = Console.ReadLine();
        }

        decimal matchesPayments = (1.94m * payment) * matchCount;

        Console.WriteLine("{0:f2}lv.", matchesPayments);

        foreach (var team in teamPoints)
        {
            if (team.Key.Equals("ManchesterCity"))
            {
                Console.WriteLine("Manchester City - {0} points.", team.Value);
            }
            else if (team.Key.Equals("ManchesterUnited"))
            {
                Console.WriteLine("Manchester United - {0} points.", team.Value);
            }
            else
            {
                Console.WriteLine("{0} - {1} points.", team.Key, team.Value);
            }
        }

        //100/100
        //decimal paymentInEuro = decimal.Parse(Console.ReadLine());
        //int numsOfMatches = 0;
        //Dictionary<string, int> teamsResult = new Dictionary<string, int>();
        //teamsResult.Add("Arsenal", 0);
        //teamsResult.Add("Chelsea", 0);
        //teamsResult.Add("Everton", 0);
        //teamsResult.Add("Liverpool", 0);
        //teamsResult.Add("ManchesterCity", 0);
        //teamsResult.Add("ManchesterUnited", 0);
        //teamsResult.Add("Southampton", 0);
        //teamsResult.Add("Tottenham", 0);

        //for (;;)
        //{
        //    string match = Console.ReadLine();
        //    if (match == "End of the league.")
        //    {
        //        break;
        //    }

        //    numsOfMatches++;
        //    match = Regex.Replace(match, " ", "");
        //    string[] teams = match.Split('1', '2', 'X');
        //    char result = ' ';

        //    for (int i = 0; i < match.Length; i++)
        //    {
        //        if (match[i] == '1' || match[i] == '2' || match[i] == 'X')
        //        {
        //            result = match[i];
        //        }
        //    }

        //    if (result == '1')
        //    {
        //        for (int index = 0; index < teamsResult.Count; index++)
        //        {
        //            var item = teamsResult.ElementAt(index);
        //            string itemKey = item.Key;
        //            if (itemKey == teams[0])
        //            {
        //                teamsResult[teams[0]] = teamsResult[teams[0]] + 3;
        //                teamsResult[teams[1]] = teamsResult[teams[1]] + 0;
        //            }
        //        }

        //    }
        //    else if (result == '2')
        //    {
        //        for (int index = 0; index < teamsResult.Count; index++)
        //        {
        //            var item = teamsResult.ElementAt(index);
        //            string itemKey = item.Key;
        //            if (itemKey == teams[1])
        //            {
        //                teamsResult[teams[1]] = teamsResult[teams[1]] + 3;
        //                teamsResult[teams[0]] = teamsResult[teams[0]] + 0;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int index = 0; index < teamsResult.Count; index++)
        //        {
        //            var item = teamsResult.ElementAt(index);
        //            string itemKey = item.Key;
        //            if (itemKey == teams[1])
        //            {
        //                teamsResult[teams[1]] = teamsResult[teams[1]] + 1;
        //                teamsResult[teams[0]] = teamsResult[teams[0]] + 1;
        //            }
        //        }
        //    }

        //}

        //decimal paymentInLv = (paymentInEuro * 1.94m) * numsOfMatches;
        //Console.WriteLine("{0:f2}lv.", paymentInLv);
        //for (int index = 0; index < teamsResult.Count; index++)
        //{
        //    var item = teamsResult.ElementAt(index);
        //    string itemKey = item.Key;
        //    int itemValue = item.Value;
        //    if (itemKey == "ManchesterUnited")
        //    {
        //        Console.WriteLine("Manchester United - {0} points.", itemValue);
        //    }
        //    else if (itemKey == "ManchesterCity")
        //    {
        //        Console.WriteLine("Manchester City - {0} points.", itemValue);

        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} - {1} points.", itemKey, itemValue);
        //    }
        //}
    }
}