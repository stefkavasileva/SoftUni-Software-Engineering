using System.Collections.Generic;

public interface ICustomCollection
{
    void Add(Person person);

    void Remove();

    IList<Person> Fetch();

    Person FindByUsername(string username);

    Person FindById(int id);
}

