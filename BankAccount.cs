using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BankAccount
    {
        private String accountNumber;
        private decimal balance;

        public BankAccount(String accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your balance is Rs. {balance}");
        }
    }
}