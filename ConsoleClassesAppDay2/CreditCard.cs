using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassesAppDay2
{
    public class CreditCard
    {
        public decimal AvailableBalance { get; set; }
        public decimal ActiveBalance { get; set; }

        public Customer CreditHolder { get; set; }

        public decimal InterestRate { get; set; }

        public void RewardsProgram()
        {
           ActiveBalance *= .01m;
        }
        public void Payment(decimal pay)
        {
            ActiveBalance -= pay;
            AvailableBalance += pay;
        }
    }
}
