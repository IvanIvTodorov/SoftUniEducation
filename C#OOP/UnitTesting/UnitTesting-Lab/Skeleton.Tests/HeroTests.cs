using Moq;
using NUnit.Framework;
using Skeleton;

[TestFixture]
public class HeroTests
{
    private const int EXP = 10;

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

        var hero = new Hero("Ivan", fakeWeapon.Object);
        hero.Attack(fakeTarget.Object);

        Assert.That(hero.Experience, Is.EqualTo(EXP));
    }
}