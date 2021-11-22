using Chainblock.Contracts;
using Chainblock.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainblockTests
    {
        private ChainBlock chainblock;
        private List<ITransaction> transactions;
        private Transaction transaction;
        private int id = 1;
        int fakeID = 5;
        private TransactionStatus status = TransactionStatus.Successfull;
        private string to = "Ivan";
        private string from = "Vanyo";
        private double amount = 5.0;

        [SetUp]
        public void SetUp()
        {
            transactions = new List<ITransaction>();       
            transaction = new Transaction(id, status, to, from, amount);
            chainblock = new ChainBlock(transactions);
            chainblock.Add(transaction);
        }


        [Test]
        public void TestIfConstructorWorksProperly()
        {
            var expectedCount = 1;

            Assert.AreEqual(expectedCount, chainblock.Count);
        }

        [Test]
        public void TestIfChainblockContainsTransaction()
        {

            Assert.IsTrue(chainblock.Contains(transaction));
            Assert.IsTrue(chainblock.Contains(transaction.Id));
        }

        [Test]
        public void IfYouAddTransactionWithSameIdThrowsException()
        {
            Assert.That(() => chainblock.Add(transaction),
                Throws.InvalidOperationException);
        }

        [Test]
        public void ChangeTransactionStatusThrowsExceptionIfNotExist()
        {

            Assert.That(() => chainblock.ChangeTransactionStatus(fakeID, TransactionStatus.Aborted),
                Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfChangeTransactionStatusWorksProperly()
        {
            var expectedStatus = TransactionStatus.Aborted;

            chainblock.ChangeTransactionStatus(id, TransactionStatus.Aborted);

            Assert.AreEqual(expectedStatus, chainblock.GetById(id).Status);

        }

        [Test]
        public void TestIfGetByidThrowsException()
        {
            Assert.That(() => chainblock.GetById(fakeID),
                Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfGetByIDWorksProperly()
        {
            var expectedTransaction = chainblock.GetById(id);

            Assert.AreEqual(id, expectedTransaction.Id);

        }

    }
}
