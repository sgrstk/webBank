using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webBank.Models.Enums;

namespace webBank.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser Owner { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Balance { get; set; }
        public Guid Iban { get; set; }
        public Currency Currency { get; set; }
        public AccountType AccountType { get; set; }


        List<Transaction> Transactions { get; set; }

        public Account()
        {

        }

        public Account(ApplicationUser owner, Currency currency, AccountType accountType)
        {
            Owner = owner;
            AccountType = accountType;
            CreatedAt = DateTime.Now;
            Balance = 0;
            Currency = currency;
            Iban = new Guid();
        }
    }
}