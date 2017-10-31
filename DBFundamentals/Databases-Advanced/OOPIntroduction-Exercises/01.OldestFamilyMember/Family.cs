using System.Collections.Generic;
using System.Linq;

public class Family
{
    public Family()
    {
        this.FamilyList = new List<Person>();
    }

    public IList<Person> FamilyList { get; protected set; }

    public void AddMember(Person member)
    {
        this.FamilyList.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.FamilyList.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}

