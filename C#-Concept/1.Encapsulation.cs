using System;

namespace OOP_Encapsulation
{
    public class BankAccount
    {
        private  readonly string _accountHolder;
        private int _balance;

        public BankAccount(string accountHolder, int balance) 
        {
            _accountHolder = accountHolder;
            _balance = balance;
        }

        public void Deposite(int balance,string accountHolder) 
        {
            if (balance < 0) 
            {
                Console.WriteLine("Value should be greater than 0");
            }
            else if (_accountHolder!=accountHolder)
            {
                Console.WriteLine("User Not Found");
            }
            else
            {
                _balance += balance;
                Console.WriteLine("Deposited Successfully")
;           }
        }
        public void withDraw(string accountHolder, int balance)
        {
            if (balance < 0)
            {
                Console.WriteLine("Value should be greater than 0");
            }
            if (_accountHolder != accountHolder)
            {
                Console.WriteLine("User Not Found");
            }
            if (balance > _balance)
            {
                Console.WriteLine("Not enought Money");
            }
            else
            {
                _balance -= balance;
                Console.WriteLine("withDraw Successfully")
;
            }
        }
        public void accountDetails()
        {
            Console.WriteLine("User "+_accountHolder);
            Console.WriteLine("Current Balance "+_balance);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Alice",10000);
            BankAccount ba2 = ba;

            ba2.accountDetails();
            ba2.withDraw("Alice", 1000);
            ba.accountDetails();
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}
