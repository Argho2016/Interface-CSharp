using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    class Account : IAccountOperations //implements
    {
        private double balance;

        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public void withdraw(double amount)
        {
            balance = balance - amount;
        }


        public void display()
        {
            Console.WriteLine(balance);
        }
    }
}
