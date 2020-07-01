using System;

namespace ConsoleClassesAppDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            Console.WriteLine("Please enter your first name");
            c.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            c.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            c.Age = int.Parse(Console.ReadLine());
            if (c.Age > 18)
            {
                CheckingAccount cCheckingAccount = new CheckingAccount();
                cCheckingAccount.RoutingNumber = "654000457";
                cCheckingAccount.Owner = c;
                c.UserCheckingAccount = cCheckingAccount;
                Console.WriteLine($"The owner of this account is: {cCheckingAccount.Owner.FirstName} {cCheckingAccount.Owner.LastName}");
                Console.WriteLine();
                
            }
            else
            {   Console.WriteLine("Youre too young!");
                
            }
            Console.WriteLine("Would you like to make a deposit?");
            var userResponse = Console.ReadLine();
            decimal amount;
            switch (userResponse)
            {
                case "deposit":
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Deposit(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;
                case "withdraw":
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Withdraw(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;
            }

            Console.WriteLine("Would you like to add an account?");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "credit":
                    Console.WriteLine("Your new account is being built ...");
                    Console.ReadLine();
                    c.UserCredit = new CreditCard();
                    c.UserCredit.ActiveBalance = 100.00m;
                    c.UserCredit.CreditHolder = c;
                    c.UserCredit.AvailableBalance = 1100;
                    Console.WriteLine($"{c.UserCredit.CreditHolder.FirstName} ,your new credit account balance is: {c.UserCredit.ActiveBalance} after all fees. Your total available credit is : {c.UserCredit.AvailableBalance} ");
                    Console.WriteLine("Would you like to make a payment?");
                    var yesOrNo = Console.ReadLine();
                    if(yesOrNo == "yes")
                    {
                        Console.WriteLine("How much would you like to pay?");
                        var paymnt = decimal.Parse(Console.ReadLine());
                        c.UserCredit.Payment(paymnt);
                        Console.WriteLine($"{c.UserCredit.CreditHolder.FirstName}, your new active balance is {c.UserCredit.ActiveBalance}, and your available credit is: {c.UserCredit.AvailableBalance}");
                        Console.ReadLine
                    }
                    break;
                case "savings":
                    Console.WriteLine("Your new account is being created. Press enter to continue:");
                    Console.ReadLine();
                    c.UserSavings = new SavingsAccount();
                    c.UserSavings.AccHolder= c;
                    c.UserSavings.AccBal = 100;
                    Console.WriteLine($"{c.UserSavings.AccHolder.FirstName}, your current balance is {c.UserSavings.AccBal}");
                    Console.WriteLine("Would you like to make a deposit?");
                    var depsav = Console.ReadLine();
                    
                    if(depsav == "yes")
                    {
                        Console.WriteLine("How much?");
                        var dollas = decimal.Parse(Console.ReadLine());
                        c.SavDep(dollas);

                        Console.WriteLine($"Your new savings balance is: {c.UserSavings.AccBal}");
                    }
                    else
                    {
                        Console.WriteLine("Have a great day!");
                    }
                    break;



            }




            Console.WriteLine($"Hello {c.FirstName}");
        }
    }
}
