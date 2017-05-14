using System.Collections.Generic;
using System.Linq;

namespace _05.FibonacciNumbers
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            this.FibNumbers = new List<long>();
        }

        public List<long> FibNumbers { get; set; }
        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {
            return this.FibNumbers.Skip(startPosition).Take(endPosition - startPosition).ToList();
        }

        public override string ToString()
        {
            return string.Join(", ", this.FibNumbers);
        }
    }
}
