using System.Linq;

namespace _04.NumberInReversedOrder
{
    class DecimalNumber
    {
        public DecimalNumber(string decimalNum)
        {
            this.decimalNumber = decimalNum;
        }

        private string decimalNumber;
        public string DecimalNumberAsStr => this.decimalNumber;

        public string ReverseNumber(string number)
        {
            return new string(decimalNumber.Reverse().ToArray());
        }
    }
}
