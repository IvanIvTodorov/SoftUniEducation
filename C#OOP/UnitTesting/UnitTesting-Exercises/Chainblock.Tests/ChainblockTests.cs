using Chainblock.Contracts;
using Chainblock.Models;
using Moq;
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
        private Transaction secondTransaction;
        private int id = 1;
        private int secId = 2;
        int fakeID = 5;
        private TransactionStatus status = TransactionStatus.Successfull;
        private string to = "Ivan";
        private string from = "Vanyo";
        private double secondAmount = 4.0;
        private double amount = 5.0;

        [SetUp]
        public void SetUp()
        {
            transactions = new List<ITransaction>();       
            transaction = new Transaction(id, status, to, from, amount);
            secondTransaction = new Transaction(secId, status, to, from, secondAmount);
            chainblock = new ChainBlock(transactions);
            chainblock.Add(transaction);
            chainblock.Add(secondTransaction);
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

        [Test]
        public void CheckIfRemoveTransactionByIDThrowsException()
        {
            Assert.That(() => chainblock.RemoveTransactionById(fakeID),
                Throws.ArgumentException);
        }

        [Test]
        public void CheckIfRemoveTransactionByIDWorksProperly()
        {
            var expectedCount = chainblock.Count - 1;

            chainblock.RemoveTransactionById(id);

            Assert.AreEqual(expectedCount, chainblock.Count);

        }

        [Test]
        public void TestIfGetByTransactionStatusThrowsException()
        {
            Assert.That(() => chainblock.GetByTransactionStatus(TransactionStatus.Aborted),
                Throws.InvalidOperationException);        
        }

        [Test]
        public void TestIfGetByTransactionStatusWorksProperly()
        {            

            Assert.AreEqual(chainblock.OrderByDescending(a => a.Amount), chainblock.GetByTransactionStatus(status));
        }

        [Test]      
        public void TestIfGetAllSendersWithTransactionStatusThrowsException()
        {
            Assert.That(() => chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Aborted),
                Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfGetAllSendersWithTransactionSatusWorksProperly()
        {
            var listofTransactions = new List<string>();

            foreach (var tx in chainblock.OrderBy(a => a.Amount).Where(s => s.Status == TransactionStatus.Successfull))
            {

                listofTransactions.Add(tx.From.ToString());
            }

            Assert.AreEqual(listofTransactions, chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void TestIfGetAllReceiversWithTransactionStatusThrowsException()
        {
            Assert.That(() => chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Aborted),
                Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfGetAllReceiverssWithTransactionSatusWorksProperly()
        {
            var listofTransactions = new List<string>();

            foreach (var tx in chainblock.OrderBy(a => a.Amount).Where(s => s.Status == TransactionStatus.Successfull))
            {

                listofTransactions.Add(tx.To.ToString());
            }

            Assert.AreEqual(listofTransactions, chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull));
        }
    }
}
