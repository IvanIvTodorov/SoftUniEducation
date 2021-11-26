using Chainblock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chainblock.Models
{  
    public class ChainBlock : IChainblock
    {
        private ICollection<ITransaction> transactions;
        private ITransaction transaction;
        private List<string> collection;
        private List<string> collectionReceivers;

        public ChainBlock(List<ITransaction> transactions)
        {
            this.transactions = transactions;
            transaction = new Transaction(1, TransactionStatus.Successfull, "Ivan", "Vanyo", 5.0);
            collection = new List<string>();
            collectionReceivers = new List<string>();
        }
        public int Count => transactions.Count;

        public void Add(ITransaction tx)
        {
            if (Contains(tx))
            {
                throw new InvalidOperationException();
            }

            transactions.Add(tx);
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (Contains(id) == false)
            {
                throw new InvalidOperationException();
            }

            var current = transactions.First(i => i.Id == id);
            current.Status = newStatus;
        }

        public bool Contains(ITransaction tx)
        {
            return Contains(tx.Id);
        }

        public bool Contains(int id)
        {
            bool IsContained = transactions.Any(tx => tx.Id == id);

            return IsContained;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return transactions.OrderByDescending(a => a.Amount).ThenBy(i => i.Id);
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            if (transactions.Any(s => s.Status == status) == false)
            {
                throw new InvalidOperationException();
            }

            foreach (var tx in transactions.OrderBy(a => a.Amount).Where(s => s.Status == status))
            {
                collectionReceivers.Add(tx.To.ToString());
            }

            return collectionReceivers;
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            if (transactions.Any(s => s.Status == status) == false )
            {
                throw new InvalidOperationException();
            }

            foreach (var tx in transactions.OrderBy(a => a.Amount).Where(s => s.Status == status))
            {
                collection.Add(tx.From.ToString());
            }

            return collection;
        }

        public ITransaction GetById(int id)
        {
            if (Contains(id) == false)
            {
                throw new InvalidOperationException();
            }

            return transactions.First(i => i.Id == id);
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            if (transactions.Any(t => t.To == receiver) == false)
            {
                throw new InvalidOperationException();
            }

            return transactions.Where(t => t.To == receiver).OrderBy(a => a.Amount).ThenBy(i => i.Id);
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            if (transactions.Any(s => s.From == sender) == false)
            {
                throw new InvalidOperationException();
            }

            return transactions.Where(s => s.From == sender).OrderByDescending(a => a.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            if (transactions.Any(s => s.Status == status) == false)
            {
                throw new InvalidOperationException();
            }

            var result = transactions.OrderByDescending(a => a.Amount);

            return result;
            
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            return transactions.GetEnumerator();
        }

        public void RemoveTransactionById(int id)
        {
            if (Contains(id) == false)
            {
                throw new ArgumentException();
            }

            var remove = GetById(id);

            transactions.Remove(remove);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
