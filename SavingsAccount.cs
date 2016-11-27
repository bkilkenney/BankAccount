using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        //Fields
        private int savingsAccountNumber;
        private decimal savingsAccountBalance;


        //Properties    
        public int SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
            set { this.savingsAccountNumber = value; }
        }

        public decimal SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }

        //Constructors      
        public SavingsAccount(string accountHolderName) : base(accountHolderName)
        {
            this.savingsAccountNumber = 13579;
            this.savingsAccountBalance = 321432.43m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.savingsAccountBalance += dollars;
            return this.savingsAccountBalance;
        }

        public override decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.savingsAccountBalance -= dollars;
            return this.savingsAccountBalance;
        }

        public override void ViewAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + SavingsAccountBalance);
        }


    }
}
