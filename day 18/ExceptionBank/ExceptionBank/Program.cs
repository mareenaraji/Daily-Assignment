using System;

namespace ExceptionBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Rahul", 2453, 500);
            try
            {
                c.withdraw(450);
            }
      catch(bankexception e)
            {
                Console.WriteLine("Transaction Failed ");
                e.inform();
            }
        }
    }
}
