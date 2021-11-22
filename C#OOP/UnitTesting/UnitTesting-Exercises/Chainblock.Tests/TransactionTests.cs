using NUnit.Framework;

using Chainblock.Common;
using Chainblock.Models;
using Chainblock.Contracts;

namespace Chainblock.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        private ITransaction transaction;
        private int id = 1;
        private TransactionStatus status = TransactionStatus.Successfull;
        private string to = "Ivan";
        private string from = "Vanyo";
        private double amount = 5.0;

        [SetUp]
        public void SetUp()
        {
            transaction = new Transaction(id, status, to, from, amount);

        }

        [Test]
        public void TestIfConstructorWorksProperly()
        {
            Assert.AreEqual(id, transaction.Id);
            Assert.AreEqual(status, transaction.Status);
            Assert.AreEqual(to, transaction.To);
            Assert.AreEqual(from, transaction.From);
            Assert.AreEqual(amount, transaction.Amount);
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        public void NegativeOrZeroIdThrowsException(int testId)
        {
            Assert.That(() => new Transaction(testId, status, to, from, amount),
                Throws.ArgumentException.With.Message.EqualTo(ExceptionMessages.InvalidId));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("          ")]
        public void EmptyNullOrWhiteSpaceNameThrowsException(string name)
        {
            Assert.That(() => new Transaction(id, status, name, from, amount),
                Throws.ArgumentException);

            Assert.That(() => new Transaction(id, status, to, name, amount),
                Throws.ArgumentException);
        }

        [Test]
        [TestCase(-1.0)]
        [TestCase(0.0)]
        public void NegativeOrZeroAmountThrowsException(double amount)
        {
            Assert.That(() => new Transaction(id, status, to, from, amount),
                Throws.ArgumentException);
        }
    }
}
