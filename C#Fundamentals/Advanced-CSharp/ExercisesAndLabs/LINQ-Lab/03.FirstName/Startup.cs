using System;
using System.Linq;

namespace _03.FirstName
{
    public class Startup
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToArray();
            var letters = Console.ReadLine().ToCharArray().Where(l => l != ' ').OrderBy(l => l).ToArray();

            var result = string.Empty;
            foreach (var letter in letters)
            {
                result = names.FirstOrDefault(x => char.ToUpper(x[0]).Equals(char.ToUpper(letter)));
                if (!string.IsNullOrEmpty(result)) break;
            }

            result = string.IsNullOrEmpty(result) ? "No match" : result;
            Console.WriteLine(result);
        }
    }
}
