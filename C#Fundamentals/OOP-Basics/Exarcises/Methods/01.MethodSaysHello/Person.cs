namespace _01.MethodSaysHello
{
    public class Person
    {
        public string personName;

        public Person(string name)
        {
            this.personName = name;
        }

        public string SayHello()
        {
            return $"{this.personName} says \"Hello\"!";
        }
    }
}
