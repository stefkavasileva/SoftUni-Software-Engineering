namespace _02.OldestFamilyMember
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }
    }
}
