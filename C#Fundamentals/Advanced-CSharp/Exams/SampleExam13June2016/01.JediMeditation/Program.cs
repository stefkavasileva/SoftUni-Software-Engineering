using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.JediMeditation
{
    public class Program
    {
        public static void Main()
        {
            //40/100
            var countOfLines = int.Parse(Console.ReadLine());
            var allJedis = new StringBuilder();
            for (int i = 0; i < countOfLines; i++)
            {
                allJedis.Append(Console.ReadLine());
            }

            var jedisM = Regex.Matches(allJedis.ToString(), "m\\d+");
            var jedisK = Regex.Matches(allJedis.ToString(), "k\\d+");
            var jedisSOrT = Regex.Matches(allJedis.ToString(), "(t\\d+)|(s\\d+)");
            var jedisP = Regex.Matches(allJedis.ToString(), "p\\d+");
            var jedisY = Regex.Matches(allJedis.ToString(), "y\\d+");

            var sb = new StringBuilder();

            if (jedisY.Count != 0)
            {
                AddJedis(jedisM, sb);
                AddJedis(jedisK, sb);
                AddJedis(jedisSOrT, sb);
                AddJedis(jedisP, sb);
            }
            else
            {
                AddJedis(jedisSOrT, sb);
                AddJedis(jedisM, sb);
                AddJedis(jedisK, sb);
                AddJedis(jedisP, sb);
            }

            Console.WriteLine(sb);
        }

        private static void AddJedis(MatchCollection jedis, StringBuilder sb)
        {
            foreach (Match match in jedis)
            {
                sb.Append($"{match.Value} ");
            }
        }
    }
}
