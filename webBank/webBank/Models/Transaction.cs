using System;
using System.ComponentModel.DataAnnotations;
using webBank.Models.Enums;

namespace webBank.Models

{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; }
        public double Amount { get; set; }
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public TransactionType TransactionType { get; set; }

        public string Details { get; set; }

        public Transaction()
        {

        }
        public Transaction(Account sender, double amount, TransactionType transactionType, Account receiver = null)
        {
            CreatedAt = DateTime.Now;
            Amount = amount;
            sender.Balance -= amount;
            TransactionType = transactionType;
            Details = transactionType.ToString();
            if (receiver != null)
            {
                receiver.Balance += amount;
            }
        }
    }
}