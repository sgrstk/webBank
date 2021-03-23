using System;
using static webBank.Utils.Utils;

namespace webBank.Models

{
    public class Transaction
    {
        public Guid AccountId { get; }
        public double Amount { get; }
        public DateTime CreatedAt { get; }

        public TransactionType Type { get; }

        public Transaction(Guid accountId, double amount, TransactionType type)
        {
            AccountId = accountId;
            Amount = amount;
            Type = type;
            CreatedAt = DateTime.Now;
        }
    }
}