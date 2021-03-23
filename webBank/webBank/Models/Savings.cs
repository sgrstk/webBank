using static webBank.Utils.Utils;
using System;
namespace webBank.Models
{

    public class Savings : Account
    {
        private const double SAVINGS_INTEREST_RATE = 0.04;

        public Savings(string ownerName) : base(ownerName) { }

        public double interestRate
        {
            get
            {
                return SAVINGS_INTEREST_RATE;
            }
        }

        override public void deposit(double amount)
        {
            Transaction trans = new Transaction(
    AccountId,
    amount,
    TransactionType.DEPOSIT
);

            Transactions.Add(trans);

            double interestEarned = amount * SAVINGS_INTEREST_RATE;

            Transaction interstTrans = new Transaction(
    AccountId,
    interestEarned,
    TransactionType.INTEREST_EARNED
);
            Transactions.Add(interstTrans);
        }
    }
}