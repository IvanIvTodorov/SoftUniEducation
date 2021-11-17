using FakeAxeAndDummy;
using FakeAxeAndDummy.Contracts;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private string name = "Ivan";
    private const int EXP = 0;
    private const int RESULT = 5;
    private Mock<IWeapon> weapon;
    private Mock<ITarget> target;
    private Hero hero;

    [SetUp]
    public void SetUp()
    {
        weapon = new Mock<IWeapon>();
        target = new Mock<ITarget>();
        hero = new Hero(name, weapon.Object);
    }

    [Test]
    public void TestIfConstructorWokrsPorperly()
    {
        var expectedName = hero.Name;
        var expectedExp = EXP;
        var expectedWeapon = hero.Weapon;

        Assert.AreEqual(expectedName, hero.Name);
        Assert.AreEqual(expectedExp, hero.Experience);
        Assert.AreEqual(expectedWeapon, hero.Weapon);

    }

    [Test]
    public void TestIfAttackMethodWorksCorrectly()
    {
        target.Setup(d => d.IsDead())
            .Returns(true);

        target.Setup(e => e.GiveExperience())
            .Returns(5);

        var expected = hero.Experience + RESULT;
        hero.Attack(target.Object);

        Assert.AreEqual(expected, hero.Experience);
    }
}