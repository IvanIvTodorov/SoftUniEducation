using FakeAxeAndDummy;
using FakeAxeAndDummy.Contracts;
using Moq;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private ITarget target;
    private const int ATTACK = 10;
    private const int DURABILITY = 20;
    [SetUp]
    public void SetUp()
    {
        axe = new Axe(ATTACK, DURABILITY);
        target = Mock.Of<ITarget>();
    }

    [Test]
    public void TestIfConstructorWorksProperly()
    {

        Assert.AreEqual(ATTACK, axe.AttackPoints);
        Assert.AreEqual(DURABILITY, axe.DurabilityPoints);

    }

    [Test]
    public void AttackThrowsExceptionWhenAxeDurabilityIsNegative()
    {
        var test = new Axe(ATTACK, -1);

        Assert.That(() => test.Attack(It.IsAny<ITarget>()),
            Throws.InvalidOperationException);
    }

    [Test]
    public void AttackShoudWorkCorrectly()
    {

        var expectedDurabilty = axe.DurabilityPoints - 1;

        axe.Attack(target);
       
        Assert.AreEqual(expectedDurabilty, axe.DurabilityPoints);
    }

}