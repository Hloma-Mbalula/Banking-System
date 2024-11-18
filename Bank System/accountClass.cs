using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Account
    {
        private string fullname;
        private double balance;
        private string accountNumber;
        private string pin;
        Random random = new Random();
        public List<Transactions> Transactions {get; private set; } = new List<Transactions>();

        public void AddTransaction(string type, double amount, double balanceAfter){
            Transactions.Add( new Transactions{
                Type = type,
                Amount = amount,
                BalanceAfter = balanceAfter,
                Date = DateTime.Now
            });
        }

        public Account(string accountHolderName, double initialBalance)
        {
            fullname = accountHolderName;
            balance = initialBalance;
            accountNumber = GenerateAccountNumber();
            pin = GeneratePin();
        }

        // getter for Full name
        public string Fullname
        {
            get { return fullname; }
        }

        // getter for ba
        public double Inibalance
        {
            get { return balance; }
            set { balance = value; }
        }

        //getter for acc number

        public string AccNumber => accountNumber;
        public string accPin => pin;

        // Acc number and Pin generator:

        private string GenerateAccountNumber()
        {
            return random.Next(10000000, 99999999).ToString();
        }

        private string GeneratePin()
        {
            return random.Next(1000, 9999).ToString();
        }

    }
}