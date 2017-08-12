using System;
using NUnit.Framework;

[TestFixture]
public class DatabaseTests
{
    private const int TestNumber = int.MinValue;
    private const int Capacity = 16;
    private const int MiddleLength = 5;

    private Database database;

    [SetUp]
    public void Init()
    {
        this.database = new Database(new int[MiddleLength]);
    }

    [Test]
    public void ThrownExceptionIfMoreElelemtsThenTheCapasityArePassedOnTheConstructor()
    {
        Assert.Throws<InvalidOperationException>(() => new Database(new int[Capacity + 1]));
    }

    [Test]
    public void AddElementShouldAddItToThenNextFreeCell()
    {
        this.database.Add(TestNumber);

        var firstIndex = database.Index;
        this.database.Add(TestNumber);

        var secondIndex = database.Index;

        Assert.AreEqual(firstIndex, secondIndex - 1);
    }

    [Test]
    public void RemoveElementShoudRemoveItOnlyLastElement()
    {
        var currentIndex = database.Index;
        database.Add(TestNumber);
        var nextIndex = database.Index;

        Assert.AreEqual(currentIndex, nextIndex - 1);
    }

    [Test]
    public void AddElementShouldThrowExceptionIfTheDatabaseIsFullAlready()
    {
        database = new Database(new int[Capacity]);

        Assert.Throws<InvalidOperationException>(() => database.Add(TestNumber));
    }

    [Test]
    public void RemoveElementShouldThrowExceptionIfTheDatabaseIsEmpty()
    {
        database = new Database(new int[0]);

        Assert.Throws<InvalidOperationException>(() => database.Remove());
    }
}

