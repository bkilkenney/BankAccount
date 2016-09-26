using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            ReserveAccount Reserve = new ReserveAccount();
            SavingsAccount Save = new SavingsAccount();
            CheckingAccount Check = new CheckingAccount();


            MainMenu();
        }

        //Methods:
        public static void MainMenu()  //Method for the main menu
        {
            Console.WriteLine("Welcome back Mr. McDuck, what would you like to do today?");
            Console.WriteLine("1. Make a Deposit");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. View Account Balances");
            Console.WriteLine("4. Exit");

            string response = Console.ReadLine();

            
          
                   
                

        }
       
        

    }

}



