using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassesAppDay2
{
    public class Customer
    {
        public string FirstName { get; set;  }

        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }

        public CreditCard UserCredit { get; set; }

        public SavingsAccount UserSavings { get; set; }
        //Default class
        public Customer()
        {

        }
        //Parameterized Ctor
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            UserCheckingAccount.Balance -= amount;
        }
        public void SavDep(decimal amount)
        {
            UserSavings.AccBal += amount;
        }

    }
}
