namespace _03.LastDigitName
{
    public class Number
    {
        public Number(string number)
        {
            this.number = number;
        }

        private string number;
        public int Digit => int.Parse(this.number.Substring(number.Length - 1));

        public string GetName()
        {
            var digitName = new string[]
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"

            };

            return digitName[this.Digit];
        }
    }
}
