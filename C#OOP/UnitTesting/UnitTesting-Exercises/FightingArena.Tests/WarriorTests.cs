using NUnit.Framework;

namespace Tests
{
    using FightingArena;
    public class WarriorTests
    {
        [Test]
        public void CheckIfConstructorWorks()
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = 100;

            Warrior warrior = new Warrior(name, dmg, hp);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(dmg, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test]
        public void TestNameIfThrowsExceptionWithNull()
        {
            string name = null;
            int dmg = 50;
            int hp = 100;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);

        }

        [Test]
        public void TestNameIfThrowsExceptionWithSpace()
        {
            string name = "    ";
            int dmg = 50;
            int hp = 100;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);

        }

        [Test]
        public void TestNameIfThrowsExceptionWithEmptyString()
        {
            string name = string.Empty;
            int dmg = 50;
            int hp = 100;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);

        }

        [Test]
        public void NegativeDamageShouldThrowException()
        {
            string name = "Ivan";
            int dmg = -1;
            int hp = 100;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);

        }

        [Test]
        public void ZeroDamageShouldThrowException()
        {
            string name = "Ivan";
            int dmg = 0;
            int hp = 100;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);
        }

        [Test]
        public void NegativeHpShouldThrowException()
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = -1;

            Assert.That(() => new Warrior(name, dmg, hp),
                Throws.ArgumentException);
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackerWithLessHpTrhowsException(int hp)
        {
            string name = "Ivan";
            int dmg = 50;

            string n1 = "Vanyo";
            int dmg1 = 50;
            int hp1 = 100;

            Warrior attacker = new Warrior(name, dmg, hp);
            Warrior defender = new Warrior(n1, dmg1, hp1);

            Assert.That(() => attacker.Attack(defender),
                Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void DefenderWithLessHpTrhowsException(int hp1)
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = 100;

            string n1 = "Vanyo";
            int dmg1 = 50;

            Warrior attacker = new Warrior(name, dmg, hp);
            Warrior defender = new Warrior(n1, dmg1, hp1);

            Assert.That(() => attacker.Attack(defender),
                Throws.InvalidOperationException);
        }

        [Test]
        public void AttackerHasLessHpThanDefenderDamageThrowsException()
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = 40;

            string n1 = "Vanyo";
            int dmg1 = 50;
            int hp1 = 100;

            Warrior attacker = new Warrior(name, dmg, hp);
            Warrior defender = new Warrior(n1, dmg1, hp1);

            Assert.That(() => attacker.Attack(defender),
                Throws.InvalidOperationException);
        }

        [Test]
        public void TestAttackerAttackDefender()
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = 100;

            string n1 = "Vanyo";
            int dmg1 = 50;
            int hp1 = 100;

            Warrior attacker = new Warrior(name, dmg, hp);
            Warrior defender = new Warrior(n1, dmg1, hp1);

            var attackerHp = attacker.HP - defender.Damage;
            var defenderHp = defender.HP - attacker.Damage;
            attacker.Attack(defender);

            Assert.AreEqual(attackerHp, attacker.HP);
            Assert.AreEqual(defenderHp, defender.HP);
        }

        [Test]
        public void TestAttackerDamageIsMoreThanDefenderHp()
        {
            string name = "Ivan";
            int dmg = 50;
            int hp = 100;

            string n1 = "Vanyo";
            int dmg1 = 50;
            int hp1 = 40;

            Warrior attacker = new Warrior(name, dmg, hp);
            Warrior defender = new Warrior(n1, dmg1, hp1);

            var expected = 0;
            attacker.Attack(defender);

            Assert.AreEqual(expected, defender.HP);
        }
    }
}