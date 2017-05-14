using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    public class Family
    {
        public List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(p => p.age).First();
        }
    }
}
