using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Websites
{
    public static void Main()
    {
        //75/100
        var inputLine = Console.ReadLine();
        var websites = new List<WebSite>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine.Split("| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var host = tokens[0];
            var domain = tokens[1];
            var queries = new List<string>();

            bool hasQuery = tokens.Length > 2;
            if (hasQuery)
            {
                queries = tokens[2].Split(',').ToList();
            }

            if (!websites.Any(w => w.Host == host && w.Domain == domain))
            {
                var website = new WebSite { Domain = domain, Host = host, Queries = new List<string>() };
                if (hasQuery)
                {
                    website.Queries.AddRange(queries);
                }

                websites.Add(website);
            }
          
            inputLine = Console.ReadLine();
        }

        foreach (var website in websites)
        {
            var result = new StringBuilder();
            result.Append($"https://www.{website.Host}.{website.Domain}");

            if (website.Queries.Any())
            {
                result.Append($"/query?=[");
                result.Append(string.Join("]&[", website.Queries) + "]");
            }

            Console.WriteLine(result);

        }
    }
}

