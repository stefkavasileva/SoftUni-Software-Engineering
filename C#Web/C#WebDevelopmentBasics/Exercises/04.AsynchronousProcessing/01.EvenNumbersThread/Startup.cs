using System;
using System.Threading;

namespace _01.EvenNumbersThread
{
    public class Startup
    {
        public static void Main()
        {
            var numberRange = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minNumber = int.Parse(numberRange[0]);
            var maxNumber = int.Parse(numberRange[1]);

            var events = new Thread(() => PrintEvenNumber(minNumber, maxNumber));
            events.Start();
            events.Join();
            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumber(int minNumber, int maxNumber)
        {
            minNumber = minNumber % 2 != 0 ? ++minNumber : minNumber;
            for (int i = minNumber; i <= maxNumber; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
