using System;
using System.Collections.Generic;
using static webBank.Utils.Utils;

namespace webBank.Models
{
    public abstract class Account
    {
        public Guid AccountId { get; }
        public string Owner { get; }
        public DateTime CreatedAt { get; }
        public List<Transaction> Transactions = new List<Transaction>();


        public Account(string ownerName)
        {
            AccountId = Guid.NewGuid();
            Owner = ownerName;
            CreatedAt = DateTime.Now;
        }
        public double getBalance()
        {
            double balance = 0.00;
            Transactions.ForEach(trans =>
            {
                switch (trans.Type)
                {
                    case TransactionType.INTEREST_EARNED:
                    case TransactionType.DEPOSIT:
                        balance += trans.Amount;
                        break;
                    case TransactionType.WITHDRAW:
                        balance -= trans.Amount;
                        break;
                }
            });
            return balance;
        }

        virtual public void deposit(double amount)
        {
            Transaction trans = new Transaction(
                AccountId,
                amount,
                TransactionType.DEPOSIT
            );
            Transactions.Add(trans);
        }

       
        public void withDraw(double amount)
        {

            Transaction trans = new Transaction(
                AccountId,
                amount,
                TransactionType.WITHDRAW);
            Transactions.Add(trans);
        }
    }
}