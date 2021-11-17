using FakeAxeAndDummy;
using Moq;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;
    private Dummy test;
    private const int HP = 100;
    private const int EXP = 100;
    private const int POINTS = 10;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(HP, EXP);
        test = new Dummy(-1, EXP);
    }

    [Test]
    public void TestIfConstructorWorksProperly()
    {
        var expectedHp = dummy.Health;

        Assert.AreEqual(expectedHp, dummy.Health);
    }

    [Test]
    public void TestIfTakeAttackMethodThrowsException()
    {
        Assert.That(() => test.TakeAttack(It.IsAny<int>()),
            Throws.InvalidOperationException);
    }

    [Test]
    public void TestIfTakeAttackMethodWorksCorrectly()
    {
        var expectedHp = dummy.Health - POINTS;

        dummy.TakeAttack(POINTS);

        Assert.AreEqual(expectedHp, dummy.Health);
    }

    [Test]
    public void TestIfGiveExperienceMethodThrowsException()
    {
        Assert.That(() => dummy.GiveExperience(),
            Throws.InvalidOperationException);       
    }

    [Test]
    public void TestIfGiveExperienceMethodWorksProperly()
    {
        var expectedExp = EXP;

        Assert.AreEqual(expectedExp, test.GiveExperience());
    }

}
