using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private const string HeroName = "Gandalf";

    [Test]
    public void HeroShouldGainExperinceWhenKillsATarget()
    {
        // Arrange
        ITarget target = new FakeTarget();
        IWeapon weapon = new FakeWeapon();
        Hero hero = new Hero(HeroName, weapon);

        // Act
        hero.Attack(target);

        // Assert
        Assert.AreEqual(20, hero.Experience, "The hero does not gain experience after killing a target.");
    }

    // Using Mock
    [Test]
    public void HeroGainExperinceWhenKillsATarget()
    {
        // Arrange
        Mock<ITarget> fakeTarget = new Mock<ITarget>();
        fakeTarget.Setup(t => t.Health).Returns(0);
        fakeTarget.Setup(t => t.GiveExperience()).Returns(20);
        fakeTarget.Setup(t => t.IsDead()).Returns(true);
        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
        Hero hero = new Hero(HeroName, fakeWeapon.Object);

        // Act
        hero.Attack(fakeTarget.Object);

        // Assert
        Assert.AreEqual(20, hero.Experience, "The hero does not gain experience after killing a target.");
    }
}
