using System;

namespace _06.PrimeChecker
{  
    public class StartUp
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var isPrime = true;

            if (number == 0 || number == 1 || number == 2)
            {
                isPrime = true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            var num = new Number(number, isPrime);
            num.GetNextPrime();
            Console.WriteLine($"{num.GetNextPrime()}, {isPrime.ToString().ToLower()}");
        }
    }
}
