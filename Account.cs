using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
   //Fields:
        private string accountHolderName;
        private decimal balance;
        private string address = "#1 Happy St., Mentor, OH. 44060";
        private string email = "SMcDuck@gmail.com";
        private string phone = "(555) 555-1234";
        private int accountNumber;

   //Properties
        public string AccountHolderName
        {
            get { return this.accountHolderName; }
            set { this.accountHolderName = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public Account(string accountHolderName)
        {
            this.AccountHolderName = accountHolderName;
        }
        //Methods

        public virtual decimal Deposit(decimal dollars)  //Virtual b/c it will be overriden with by inheriting classes
        {
            this.balance += dollars;
            return balance;           
        }

        public virtual decimal Withdrawl(decimal dollars)  //Virtual b/c it will be overriden with by inheriting classes
        {
            this.balance -= dollars;
            return balance;
        }

        public virtual void ViewAccountBalance()
        {
            Console.WriteLine("Balance: " + balance);
        }

        public void CustomerInfo()
        {
            Console.WriteLine("Name: " + accountHolderName);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Address: " + address);
        }
    }
}
