using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {


    //Fields
        private int checkingAccountNumber;
        private decimal checkingAccountBalance;


    //Properties    
        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
            set { this.checkingAccountNumber = value; }
        }

        public decimal CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }

    //Constructors      
        public CheckingAccount(string accountHolderName) : base(accountHolderName)
        {
            this.checkingAccountNumber = 24680;
            this.checkingAccountBalance = 5437.95m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.checkingAccountBalance += dollars;
            return this.checkingAccountBalance;
        }

        public override decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.checkingAccountBalance -= dollars;
            return this.checkingAccountBalance;
        }

        public override void ViewAccountBalance()
        {
            Console.WriteLine("Checking account balance: $" + CheckingAccountBalance);
        }



    }
}
