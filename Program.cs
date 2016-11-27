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

            //Create text files for each account
            StreamWriter swReserve = new StreamWriter("ReserveAccount.txt");
            StreamWriter swSavings = new StreamWriter("Savings.txt");
            StreamWriter swChecking = new StreamWriter("Checking.txt");

            //Get name from user
            Console.WriteLine("Enter customer name: ");
            string accountHolderName = Console.ReadLine();
            Console.Clear();

            //Instances of each account
            ReserveAccount Reserve = new ReserveAccount(accountHolderName);
            SavingsAccount Save = new SavingsAccount(accountHolderName);
            CheckingAccount Check = new CheckingAccount(accountHolderName);


            //Start the .txt file for each account
            swReserve.WriteLine("Customer: " + accountHolderName);
            swReserve.WriteLine("Account Type: Reserve");
            swReserve.WriteLine("Account #: " + Reserve.ReserveAccountNumber);
            swReserve.WriteLine("Balance: $" + Reserve.ReserveAccountBalance);

            swChecking.WriteLine("Customer: " + accountHolderName);
            swChecking.WriteLine("Account Type: Checking");
            swChecking.WriteLine("Account #: " + Check.CheckingAccountNumber);
            swChecking.WriteLine("Balance: $" + Check.CheckingAccountBalance);

            swSavings.WriteLine("Customer: " + accountHolderName);
            swSavings.WriteLine("Account Type: Savings");
            swSavings.WriteLine("Account #: " + Save.SavingsAccountNumber);
            swSavings.WriteLine("Balance: $" + Save.SavingsAccountBalance);

            //loop for menu
            while (true)
            {
                //menu
                Console.WriteLine("Welcome, please select from the following menu: ");
                Console.WriteLine("1: View Customer Information");
                Console.WriteLine("View Balance:");
                Console.WriteLine("\t2: Checking Account");
                Console.WriteLine("\t3: Savings Account");
                Console.WriteLine("\t4: Reserve Account");
                Console.WriteLine("5: Deposit Funds");
                Console.WriteLine("6: Withdrawal Funds");
                Console.WriteLine("7: Exit");

                //Convert user input to int for switch case
                int action = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (action)
                {
                    case 1:
                        Save.CustomerInfo();
                        break;

                    case 2:
                        Check.ViewAccountBalance();
                        break;


                    case 3:
                        Save.ViewAccountBalance();
                        break;


                    case 4:
                        Reserve.ViewAccountBalance();
                        break;

                    case 5:
                        //asks user where they want to make a deposit and the adds funds to that account
                        Console.WriteLine("Where would you like to make a deposit?");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");


                        int choice = int.Parse(Console.ReadLine());


                        Console.WriteLine("How much would you like to deposit?");


                        decimal deposit = decimal.Parse(Console.ReadLine());


                        switch (choice)
                        {
                            case 1:
                                Check.Deposit(deposit);
                                Console.WriteLine("The new balance is " + Check.CheckingAccountBalance);
                                swChecking.WriteLine("+ " + deposit + " " + DateTime.Now);
                                swChecking.WriteLine("Account Balance: " + Check.CheckingAccountBalance);
                                break;


                            case 2:
                                Save.Deposit(deposit);
                                Console.WriteLine("The new balance is " + Save.SavingsAccountBalance);
                                swSavings.WriteLine("+ " + deposit + " " + DateTime.Now);
                                swSavings.WriteLine("Account Balance: " + Save.SavingsAccountBalance);
                                break;


                            case 3:
                                Reserve.Deposit(deposit);
                                Console.WriteLine("The new balance is " + Reserve.ReserveAccountBalance);
                                swReserve.WriteLine("+ " + deposit + " " + DateTime.Now);
                                swReserve.WriteLine("Account Balance: " + Reserve.ReserveAccountBalance);
                                break;


                            default:
                                break;


                        }
                        break;


                    case 6:
                        //asks user where to withdrawal and then takes funds from that account
                        Console.WriteLine("Withdrawl from: ");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");


                        int pick = int.Parse(Console.ReadLine());


                        Console.WriteLine("How much would you like to withdrawal?");


                        decimal withdrawl = decimal.Parse(Console.ReadLine());


                        switch (pick)
                        {
                            case 1:
                                Check.Withdrawl(withdrawl);
                                Console.WriteLine("The new balance is " + Check.CheckingAccountBalance);
                                swChecking.WriteLine("- " + withdrawl + " " + DateTime.Now);
                                swChecking.WriteLine("Account Balance: " + Check.CheckingAccountBalance);
                                break;


                            case 2:
                                Save.Withdrawl(withdrawl);
                                Console.WriteLine("The new balance is " + Save.SavingsAccountBalance);
                                swSavings.WriteLine("- " + withdrawl + " " + DateTime.Now);
                                swSavings.WriteLine("Account Balance: " + Save.SavingsAccountBalance);
                                break;


                            case 3:
                                Reserve.Withdrawl(withdrawl);
                                Console.WriteLine("The new balance is " + Reserve.ReserveAccountBalance);
                                swReserve.WriteLine("- " + withdrawl + " " + DateTime.Now);
                                swReserve.WriteLine("Account Balance: " + Reserve.ReserveAccountBalance);
                                break;
                        }
                        break;

                    case 7:
                        //quits to ask if they want to do anything else
                        break;


                    default:
                        //quits to ask if they want to do anything else
                        break;

                }


                Console.WriteLine("Would you like to continue? Y or N?");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() == "y")
                {
                    //clears console and goes back to the menu since in a loop
                    Console.Clear();
                }
                else
                {
                    //breaks out of loop and quits the program
                    Console.Clear();
                    break;
                }


            }


            //closes the streamwriters
            swReserve.Close();
            swSavings.Close();
            swChecking.Close();


            Quit();
        }

     //method to quit
        static void Quit()
        {
            Console.WriteLine("Thank you, have a nice day.");
            Environment.Exit(0);
        }
    }
}




