using System;

namespace _06.PrimeChecker
{
    public class Number
    {
        public long Value { get; set; }
        public bool IsPrime { get; set; }

        public Number(long value, bool isPrime)
        {
            this.Value = value;
            this.IsPrime = isPrime;
        }

        public long GetNextPrime()
        {
            long nextNumber = this.Value + 1;

            while (true)
            {
                bool isPrime = true;
                if (this.Value == 0 || this.Value == 1)
                {
                    return this.Value + 1;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(nextNumber); i++)
                    {
                        if (nextNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        return nextNumber;
                    }
                }

                nextNumber++;
            }
        }
    }
}
