using System;

namespace _03.AnimalFarm
{
    public class Chicken
    {
        private double productPerDay;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ProductPerDay = productPerDay;
        }

        private string name;
        private int age;

        public double ProductPerDay
        {
            get { return this.productPerDay; }
            private set { this.productPerDay = CalculateProductPerDay(); }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Equals(" "))
                {
                    throw new ArgumentException($"Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException($"Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
