using System;
using System.Collections.Generic;
using System.Linq;

public class DataBase : ICustomCollection
{
    private const string EmptyCollectionExeptionMessage = "The collection is already empty.";

    private readonly IList<Person> people;
    private int currentIndex;

    public DataBase(IList<Person> people)
    {
        foreach (var person in people)
        {
            this.people[this.currentIndex] = person;
            this.currentIndex++;
        }
    }

    public int Index => this.currentIndex;

    public void Remove()
    {
        if (this.currentIndex == 0)
        {
            throw new InvalidOperationException(EmptyCollectionExeptionMessage);
        }

        this.people[this.currentIndex - 1] = null;
        this.currentIndex--;
    }

    public IList<Person> Fetch()
    {
        return this.people.Take(currentIndex).ToList();
    }

    public Person FindByUsername(string username)
    {
        if (!people.Any(x => x.Name.Equals(username)))
        {
            throw new InvalidOperationException("The person doesn't exists.");
        }

        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentNullException("Username is required for searching.");
        }

        return people.FirstOrDefault(x => x.Name.Equals(username));
    }

    public Person FindById(int id)
    {
        if (!people.Any(x => x.Id.Equals(id)))
        {
            throw new InvalidOperationException("The person doesn't exists.");
        }

        if (id < 0)
        {
            throw new ArgumentOutOfRangeException("Id has to be positive numbers.");
        }

        return people.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Add(Person person)
    {
        if (people.Any(x => x.Name.Equals(person.Name)) || people.Any(x => x.Id.Equals(person.Id)))
        {
            throw new InvalidOperationException("The person already exists.");
        }

        people.Add(person);
    }
}

