using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ReserveAccount : Account
    {

        //Fields
        private int reserveAccountNumber;
        private decimal reserveAccountBalance;


        //Properties    
        public int ReserveAccountNumber
        {
            get { return this.reserveAccountNumber; }
            set { this.reserveAccountNumber = value; }
        }

        public decimal ReserveAccountBalance
        {
            get { return this.reserveAccountBalance; }
            set { this.reserveAccountBalance = value; }
        }

        //Constructors      
        public ReserveAccount(string accountHolderName) : base(accountHolderName)
        {
            this.reserveAccountNumber = 12345;
            this.reserveAccountBalance = 150.48m;
        }

        //Methods

        public override decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.reserveAccountBalance += dollars;
            return this.reserveAccountBalance;
        }

        public override decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.reserveAccountBalance -= dollars;
            return this.reserveAccountBalance;
        }

        public override void ViewAccountBalance()
        {
            Console.WriteLine("Reserve account balance: $" + ReserveAccountBalance);
        }
    }
}
