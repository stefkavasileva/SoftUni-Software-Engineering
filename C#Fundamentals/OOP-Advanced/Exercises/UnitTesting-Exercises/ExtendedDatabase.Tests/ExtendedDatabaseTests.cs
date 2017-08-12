using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class ExtendedDatabaseTests
{
    private const int NegativeIdTest = int.MinValue;
    private const string TestName = "SomeName";
    private const int TestId = 1;

    private DataBase database;

    [SetUp]
    public void Init()
    {
        this.database = new DataBase(new List<Person>());
    }

    [Test]
    public void AddElementShouldAddItToThenNextFreeCell()
    {
        this.database.Add(new Person(TestName, TestId));

        var firstIndex = database.Index;
        this.database.Add(new Person(TestName + TestId, TestId + TestId));

        var secondIndex = database.Index;

        Assert.AreEqual(firstIndex, secondIndex - 1);
    }

    [Test]
    public void RemoveElementShoudRemoveItOnlyLastElement()
    {
        var currentIndex = database.Index;
        database.Add(new Person(TestName, TestId));
        var nextIndex = database.Index;

        Assert.AreEqual(currentIndex, nextIndex - 1);
    }

    [Test]
    public void RemoveElementShouldThrowExceptionIfTheDatabaseIsEmpty()
    {
        database = new DataBase(new List<Person>(0));

        Assert.Throws<InvalidOperationException>(() => database.Remove());
    }

    [Test]
    public void AddPersonWithSameNameShoudThrowExeption()
    {
        database.Add(new Person(TestName, TestId));
        Assert.Throws<InvalidOperationException>(() => database.Add(new Person(TestName, TestId + TestId)));
    }

    [Test]
    public void AddPersonWithSameIdShoudThrowExeption()
    {
        database.Add(new Person(TestName, TestId));
        Assert.Throws<InvalidOperationException>(() => database.Add(new Person(TestName + TestName, TestId)));
    }

    [Test]
    public void ThrowExIfDoesntExistUserWithGivenName()
    {
        this.database.Add(new Person(TestName, TestId));
        Assert.Throws<InvalidOperationException>(() => database.Add(new Person(TestName, TestId + TestId)));
    }

    [Test]
    public void ThrowExIfUserNameIdNull()
    {
        Assert.Throws<InvalidOperationException>(() => database.Add(null));
    }

    [Test]
    public void ThrowExIfDoesntExistUserWithGivenId()
    {
        this.database.Add(new Person(TestName, TestId));
        Assert.Throws<InvalidOperationException>(() => database.Add(new Person(TestName+TestId, TestId)));
    }

    [Test]
    public void ThrowExIfIdIsNegative()
    {
        Assert.Throws<InvalidOperationException>(() => database.Add(new Person(TestName , NegativeIdTest)));
    }
}

