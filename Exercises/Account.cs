using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day2.Exercises
{
    internal class Account
    {
        public double Balance { get; set; }
        public AccountOwner AccountOwner { get; set; }

        public Account(double balance, AccountOwner accountOwner)
        {
            Balance = balance;
            AccountOwner = accountOwner;
        }

        public  void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine(GetUpdateMessage());
        }

        public  void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(GetUpdateMessage());
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public  string GetUpdateMessage()
        {
            return $"Din konto er blevet opdateret. Der står nu kr. {Balance}";
        }
    }
}
