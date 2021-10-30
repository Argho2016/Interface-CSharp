using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    interface IAccountOperations
    {
        public void deposit(double amount);
        public void withdraw(double amount);
        public void display();
    }
}
