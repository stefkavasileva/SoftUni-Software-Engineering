using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttackPoints = 10;
        private const int DurabilityPoints = 10;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private IWeapon axe;
        private ITarget dummy;

        [SetUp]
        public void Init()
        {
            this.axe = new Axe(AxeAttackPoints, DurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            //Arrange
            this.axe = new Axe(AxeAttackPoints, DurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
    }
}
