using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    public class Startup
    {
        public static void Main()
        {
            var lineCount = int.Parse(Console.ReadLine());

            var companies = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < lineCount; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {'|', '-'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.Trim())
                    .ToArray();
                var companyName = tokens[0];
                var productCount = int.Parse(tokens[1]);
                var productName = tokens[2];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName,new Dictionary<string, long>());
                }

                if (!companies[companyName].ContainsKey(productName))
                {
                    companies[companyName].Add(productName,0);
                }

                companies[companyName][productName] += productCount;
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var result = new StringBuilder();
            foreach (var company in companies)
            {
                result.Append($"{company.Key}: ");
                var currentLine = string.Empty;
                foreach (var product in company.Value)
                {
                     currentLine += $"{product.Key}-{product.Value}, ";
                }

                currentLine = currentLine.Trim(new char[] {' ', ','});
                result.AppendLine(currentLine);
            }

            Console.Write(result);
        }
    }
}
