
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Main setup and login
            while (true)
            {
                Console.WriteLine("Welcome to Falcone Bank!");
                Console.WriteLine("Let's get you an account with us!\n");
                Console.Write("Enter Your Full Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Your Initial Balance: ");
                double initialBalance = Convert.ToDouble(Console.ReadLine());

                var newAccount = new Account(name, initialBalance);

                Console.WriteLine("\nLet's Confirm Your Details:");
                Console.WriteLine($"Account Name: {newAccount.Fullname}");
                Console.WriteLine($"Initial Balance: R{newAccount.Inibalance}\n");

                Console.WriteLine("Press 1 to confirm details: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 1)
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Thanks for Confirming! Your account setup is complete.");
                Console.WriteLine($"Account Number: {newAccount.AccNumber}  PIN: {newAccount.accPin}");
                Console.Write("Press Enter to proceed...\n");
                Console.ReadLine();
                Console.Clear();

                var methods = new MethodsProg(newAccount);

                // Login flow
                while (true)
                {
                    Console.WriteLine("Welcome To Falcone Bank!\n");
                    Thread.Sleep(100);
                    Console.WriteLine("Please enter your login details\n");
                    Thread.Sleep(100);
                    Console.Write("Please enter your Account Number: ");
                    string enteredAccNumber = Console.ReadLine();

                    Console.Write("Please enter your Pin: ");
                    string enteredPin = Console.ReadLine();

                    if (enteredAccNumber != newAccount.AccNumber || enteredPin != newAccount.accPin)
                    {
                        Console.WriteLine("Incorrect Account Number or PIN. Please try again!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Login Successful!");
                        Thread.Sleep(2000);
                        Console.Clear();

                        // Run the menu after successful login
                        RunMenu(methods);
                        break; // Exit login loop if menu is exited
                    }
                }

                break; // Exit account creation loop
            }
        }

        // Menu logic
        static void RunMenu(MethodsProg methods)
        {
            while (true)
            {
                Console.Clear();
                methods.PrintBox();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: // Balance Inquiry
                        Console.Clear();
                        methods.PrintBalance();
                        Console.WriteLine("\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        break;

                    case 2: // Deposit
                        Console.Clear();
                        methods.Deposit();
                        Console.WriteLine("\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        break;

                    case 3: // Withdrawal
                        Console.Clear();
                        methods.Withdraw();
                        Console.WriteLine("\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        break;

                    case 4: // Third Party Transfer
                        Console.Clear();
                        methods.ThirdPartyTransfer();
                        Console.WriteLine("\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        break;

                    case 5: // View Transactions
                        Console.Clear();
                        methods.ViewTransactions();
                        Console.WriteLine("\nPress Enter to return to the menu.");
                        Console.ReadLine();
                        break;

                    case 6: // Logout
                        Console.WriteLine("Thank you for using Falcone Bank. Goodbye!");
                        Thread.Sleep(2000);
                        return; // Exit the menu loop

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}






