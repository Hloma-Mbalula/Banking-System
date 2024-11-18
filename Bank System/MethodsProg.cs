using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace System
{
    public class MethodsProg
    {
        private Account _account;
        

        public MethodsProg(Account account)
        {
            _account = account;
        }
        // Initialize Box
        public void PrintBox()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("*        Falcone Bank             *");
            Console.WriteLine(" **********************************");
            Console.WriteLine($"* {MenuOptions.Options[1]}                  *");
            Console.WriteLine($"* {MenuOptions.Options[2]}                    *");
            Console.WriteLine($"* {MenuOptions.Options[3]}                      *");
            Console.WriteLine($"* {MenuOptions.Options[4]}            *");
            Console.WriteLine($"* {MenuOptions.Options[5]}                    *");
            Console.WriteLine($"* {MenuOptions.Options[6]}                          *");
            Console.WriteLine(" **********************************");
            Console.Write("Please select an option: ");
        }

        //Balance Equiry Method
        public void PrintBalance()
        {
            Console.WriteLine($"Your balance is: R{_account.Inibalance}");
        }

        //Deposit Method
        public void Deposit(){
            Console.Write("Enter the amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            _account.Inibalance += amount;
            _account.AddTransaction("Deposit", amount, _account.Inibalance);

            Console.WriteLine($"Deposit successful. New balance: R{_account.Inibalance}");
        }

        //Withdrawal Methods
        public void Withdraw()
        {
            Console.WriteLine($"Here is your current balance: R{_account.Inibalance}");
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= _account.Inibalance)
            {
                _account.Inibalance -= amount;
                _account.AddTransaction("Withdrawal", amount, _account.Inibalance);

                Console.WriteLine($"Withdrawal successful. New balance: R{_account.Inibalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        //Third Party Transfer Method
        public void ThirdPartyTransfer(){
            Console.WriteLine($"Here is your current balance: R{_account.Inibalance}");
            Console.Write("Enter the amount to transfer: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= _account.Inibalance)
            {
                _account.Inibalance -= amount;
                _account.AddTransaction("Transfer", amount, _account.Inibalance);

                Console.WriteLine($"Transfer successful. New balance for {_account.Fullname}: R{_account.Inibalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        //Transactions Method
        public void ViewTransactions(){
            if(_account.Transactions.Count == 0){
                Console.WriteLine("No transactions found.");
                return;
            }
            else{
                Console.WriteLine("Your Transactions:\n");
                foreach(var transaction in _account.Transactions){
                    Console.WriteLine($"{transaction.Date} - {transaction.Type}: R{transaction.Amount}, New Balance: R{transaction.BalanceAfter}");
                }
            }
            
        }

        //Log out Method
        public void LogoutMethod(){
            Console.WriteLine("Thank you using Falcone Banking!");
            Console.WriteLine("Loging out...");
            Thread.Sleep(4000);
            Console.Write("Successsfully logged out!");
        }


    }
        
}