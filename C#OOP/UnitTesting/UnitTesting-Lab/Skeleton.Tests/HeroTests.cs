using Moq;
using NUnit.Framework;
using Skeleton;

[TestFixture]
public class HeroTests
{
    private const int EXP = 10;

    private Hero hero;
    [SetUp]
    public void CreateHero()
    {
        hero = new Hero("Ivan");
    }
    [Test]
    public void HeroGainsXPWhenTargetDies()
    {
        var fakeTarget = new Mock<ITarget>();
        var fakeWeapon = new Mock<IWeapon>();

        fakeTarget
            .Setup(t => t.IsDead())
            .Returns(true);

        fakeTarget
            .Setup(exp => exp.GiveExperience())
            .Returns(EXP);

        hero.Attack(fakeTarget.Object);

        Assert.That(hero.Experience, Is.EqualTo(EXP));
    }
}