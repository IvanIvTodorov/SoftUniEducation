using NUnit.Framework;

namespace Tests
{
    using FightingArena;
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior defender;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            attacker = new Warrior("Ivan", 50, 100);
            defender = new Warrior("Vanyo", 40, 90);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void EnrollShouldAddWarriorToArena()
        {
            arena.Enroll(attacker);

            Assert.That(arena.Warriors, Has.Member(attacker));
        }

        [Test]
        public void EnrollShouldIncreaseArenaCount()
        {
            arena.Enroll(attacker);
            arena.Enroll(defender);

            var expected = 2;
            var actual = arena.Warriors.Count;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void EnrollSameWarriorShouldThrowException()
        {
            arena.Enroll(attacker);

            Assert.That(() => arena.Enroll(attacker),
                Throws.InvalidOperationException);

        }

        [Test]
        public void EnrollWithSameNameThrowsException()
        {
            var copy = new Warrior(attacker.Name, attacker.Damage, attacker.HP);

            arena.Enroll(attacker);

            Assert.That(() => arena.Enroll(copy),
                Throws.InvalidOperationException);
        }

        [Test]
        public void FightWithMissingAttackerThrowsException()
        {
            arena.Enroll(defender);

            Assert.That(() => arena.Fight(attacker.Name, defender.Name),
                Throws.InvalidOperationException);

        }

        [Test]
        public void FightWithMissingDefenderThrowsException()
        {
            arena.Enroll(attacker);

            Assert.That(() => arena.Fight(attacker.Name, defender.Name),
                Throws.InvalidOperationException);

        }

        [Test]
        public void FightBetweenTwoWarriorsShouldWorkCorrectly()
        {
            arena.Enroll(attacker);
            arena.Enroll(defender);

            var attackerHp = attacker.HP - defender.Damage;
            var defenderHp = defender.HP - attacker.Damage;

            arena.Fight(attacker.Name, defender.Name);

            var attackerActual = attacker.HP;
            var defenderActual = defender.HP;

            Assert.AreEqual(attackerHp, attackerActual);
            Assert.AreEqual(defenderHp, defenderActual);
        }
    }
}
