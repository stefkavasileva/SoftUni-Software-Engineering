using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;
    private const int DummyHealth = 10;
    private const int DeathDummyHealth = 0;
    private const int DummyExperience = 10;

    [SetUp]
    public void Init()
    {
        this.dummy = new Dummy(DummyHealth, DummyExperience);
    }

    [Test]
    public void DummyLosesHealtAfterAttack()
    {
        //Act
        dummy.TakeAttack(3);

        //Assert
        Assert.AreEqual(7, dummy.Health);
    }

    [Test]
    public void DeadDummyThrowsExIfAttacked()
    {
        //Arrange
        this.dummy.Health = DeathDummyHealth;

        //Assert
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void DeadDummyCanGiveXp()
    {
        //Arrange
        this.dummy.Health = DeathDummyHealth;

        //Assert
        Assert.AreEqual(10, dummy.GiveExperience());
    }

    [Test]
    public void AliveDummyCantGiveXp()
    {
        //Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}

