using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private Axe brokenAxe;
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void CreateAxeAndDummy()
    {
        brokenAxe = new Axe(10, 0);
        axe = new Axe(10, 10);
        dummy = new Dummy(10, 10);
    }
    [Test]
    public void AxeLoosesDurabilityAfterAttack()
    {
        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => brokenAxe.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));

    }
}