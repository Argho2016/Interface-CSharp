using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    class Customer : Person
    {

        private Account acc; //association

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        public void performDeposit(double amount)
        {
            acc.deposit(amount);
        }

        public void performWithdraw(double amount)
        {
            acc.withdraw(amount);
        }
        public void performDisplay()
        {
            acc.display();
        }


    }
}
