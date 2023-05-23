using System;

namespace ExceptionBank
{
     class Customer
    {
        string name; int accno; int balance;
        public Customer()
        {

        }
        public Customer(string n, int a, int b)
        {
            name = n;
            accno = a;
            balance = b;
        }
        public void withdraw(int amt)
        {
            if (balance - amt <= 100)
                throw new bankexception(accno, balance);
            balance -= amt;
        }
        public int getbalance()
        {
            return balance;
        }
    } // end of customer class
}

