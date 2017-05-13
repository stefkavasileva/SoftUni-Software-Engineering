using System.Collections.Generic;
using System.Text;

namespace _09.Google
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Car = new Car();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public string Name { get; set; }
        public Company Company { get; set; }
        public Car Car { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine($"Company:");
            if (this.Company.Name != null)
            {
                sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");
            }

            sb.AppendLine($"Car:");

            if (this.Car.Model != null)
            {
                sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            sb.AppendLine($"Pokemon:");
            foreach (var pokemon in this.Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }

            sb.AppendLine($"Parents:");
            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }

            sb.AppendLine($"Children:");
            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }

            return sb.ToString().Trim();
        }
    }
}
