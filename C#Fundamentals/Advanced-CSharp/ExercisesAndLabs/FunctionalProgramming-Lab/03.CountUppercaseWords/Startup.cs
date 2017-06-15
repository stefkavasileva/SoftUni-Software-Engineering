using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine,Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Where(x=>char.IsUpper(x[0]))));
        }
    }
}
