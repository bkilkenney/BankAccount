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
        private string accountHolderName = "Scrooge McDuck";
        private int accountNumber = 8675309;
        private string accountType;
        private decimal balance = 65873592.52m;


    //Properties    
        public int CheckingAccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string Type
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
       

      
    //Constructors      
        public CheckingAccount()
        {

        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance += dollars;
            return balance;
        }

        public override decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance -= dollars;
            return balance;
        }
    }
}
