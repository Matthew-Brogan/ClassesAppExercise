using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassesAppDay2
{
    public class CheckingAccount
    {
        
        public decimal _balance;
        public decimal Balance 
        { 
            get
            {
                return _balance;

            }
            set 
            {
                Console.WriteLine("Please enter your pin");
                string pin = "1234";
                string userPin = Console.ReadLine();
                if( userPin == pin)
                {
                    _balance += value;
                }
                else
                {
                    Console.WriteLine("User I.D. Invalid");
                }
            }
        }
        
        public string AccountNumber { get; set; }
        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;
            }
            set
            { 
                if(value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Routing Number is too Long");
                }
            }

        }
 
        public Customer Owner { get; set; }

        public void PrintBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
        }

    }
}
