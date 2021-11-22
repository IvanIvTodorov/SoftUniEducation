using Chainblock.Common;
using Chainblock.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chainblock.Models
{
    public class Transaction : ITransaction
    {
        private const int MIN_ID_VAL = 0;
        private const int MIN_AMOUNT_VAL = 0;
        private int id;
        private TransactionStatus status;
        private string from;
        private string to;
        private double amount;

        public Transaction(int id, TransactionStatus status,string to, string from, double amount)
        {
            Id = id;
            Status = status;
            To = to;
            From = from;
            Amount = amount;


        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= MIN_ID_VAL)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidId);
                }

                id = value;
            }
        }
        public TransactionStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string From
        {
            get
            {
                return from;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                from = value;
            }
        }
        public string To
        {
            get
            {
                return to;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                to = value;
            }
        }
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value <= MIN_AMOUNT_VAL)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAmount);
                }

                amount = value;
            }
        }
    }
}
