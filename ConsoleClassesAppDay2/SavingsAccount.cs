using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleClassesAppDay2
{
    public class SavingsAccount
    {
        public decimal AccBal { get; set; }
        public decimal Interest { get; set; }
        public Customer AccHolder { get; set; }

        public void IntestAccumulation()
        {
            var totalInterest = Interest* AccBal;
            Console.WriteLine(totalInterest);
        }
        public void Deposit(decimal amount)
        {
            AccBal += amount;
        }

    }
}
