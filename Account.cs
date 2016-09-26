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
        public string accountHolderName = "Scrooge McDuck";
        private int accountNumber = 8675309;
        private decimal balance = 5000.00m;


   //Properties
        public string AccountHolder
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
        public Account()
        {

        }
        //Methods

        public virtual decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance += dollars;
            return balance;           
        }

        public virtual decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance -= dollars;
            return balance;
        }
    }
}
