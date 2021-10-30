using System;

namespace ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.setName("John");
            e1.setId("e-1");
            e1.setAge(21);

            Account a1 = new Account();
            a1.setBalance(500);

            Customer c1 = new Customer();
            c1.setAge(22);
            c1.setName("Cena");
            c1.setAcc(a1);



            c1.performDeposit(500);
            c1.performWithdraw(300);
            Console.WriteLine(c1.getAge());
            Console.WriteLine(c1.getName());
            c1.performDisplay();

            Console.Read();
        }
    }
}
