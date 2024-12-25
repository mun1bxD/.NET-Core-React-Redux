using System;

namespace OOP_Inheritance_001
{
    //Single inheritance
    public class Account
    {
        protected string _accountNumber { get; set; }
        protected string _accountHolderName { get; set; }
        protected decimal   _balance { get; set; }

        //expression-bodied member syntax
        public Account(string accountNumber,string accountHolderName)=>
            (_accountHolderName,_accountNumber)=(accountNumber,accountHolderName);

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}");
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {_balance:C}");
        }
    }
    public class SavingAccounts : Account
    {
        public SavingAccounts(string accountNumber, string accountHolderName,  decimal balance) :base(accountNumber,accountHolderName)
        {
            Deposit(balance);
        }
        public void CalculateInterest(decimal interestRate)
        {
            if (interestRate <= 0)
            {
                Console.WriteLine("Interest rate must be positive.");
                return;
            }
            decimal interest = _balance * interestRate / 100;
            Deposit(interest); 
            Console.WriteLine($"Interest added: {interest:C}");
        }

        public override void Withdraw(decimal amount)
        {
            if (_balance - amount < 100)
            {
                Console.WriteLine("Cannot withdraw, balance must remain above $100.");
            }
            base.Withdraw(amount);
        }
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Account account = new Account("Alice","1234567654321");
            account.ShowBalance();

            
            SavingAccounts savingAccounts = new SavingAccounts("Alice", "1234567654321",100000);
            savingAccounts.Withdraw(1000);

            savingAccounts.ShowBalance();
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}

/*
 Point:
1. The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for 
    it to be overridden in a derived class. 
2.The base keyword is used to access members of the base class from within a derived class. Use it if you want to:

    -> Call a method on the base class that has been overridden by another method.
    -> Specify which base-class constructor should be called when creating instances of the derived class.

 */