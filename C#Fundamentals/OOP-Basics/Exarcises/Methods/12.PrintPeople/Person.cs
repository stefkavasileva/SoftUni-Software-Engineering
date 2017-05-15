using System;

namespace _12.PrintPeople
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string occupation)
        {
            this.Name = name;
            this.Age = age;
            this.Occupation = occupation;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }


        public int CompareTo(Person that)
        {
            if (this.Age < that.Age) return -1;
            if (this.Age == that.Age) return 0;
            return 1;
        }

        public override string ToString()
        {
            return $"{this.Name} - age: {this.Age}, occupation: {this.Occupation}";
        }
    }
}
