using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private Dummy deathDummy;
    private Dummy aliveDummy;

    [SetUp]
    public void SetDummy()
    {
        this.deathDummy = new Dummy(0, 100);
        this.aliveDummy = new Dummy(10, 100);
    }

    [Test]
    public void DummyLosesHealthAfterAttack()
    {
        aliveDummy.TakeAttack(1);

        Assert.That(aliveDummy.Health, Is.EqualTo(9));
    }

    [Test]
    public void DummyIsDead()
    {
        Assert.That(
            () => deathDummy.TakeAttack(1), 
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."), "Dummy not dead!");
    }

    [Test]
    public void DeathDummyCanGiveXP()
    {

        Assert.That(deathDummy.GiveExperience(), Is.EqualTo(100), "Alive dummy can't give XP");
    }

    [Test]
    public void AlliveDummyCanNotGiveXP()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => aliveDummy.GiveExperience());

        Assert.That(ex.Message, Is.EqualTo("Target is not dead."), "Dummy still alive");
    }
}
