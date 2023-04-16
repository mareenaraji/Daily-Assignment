using System;

namespace menu
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;
        public  Account()
        {
            Console.WriteLine("Account Created");
        }

        public void CreateAccount(int id, string name, decimal balance)
        {
            //throw new NotImplementedException();
            Id = id;
            Name = name;
            Balance = balance;
        }

      
        public void displayinfo()
        {
            //throw new NotImplementedException();
            Console.WriteLine("*******************************************");
            Console.WriteLine("ACCOUNT INFORMATION");
            Console.WriteLine("Account Id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance:" + Balance);
        }


        public void Deposit(int amount)
        {
            //throw new NotImplementedException();
            Balance += amount;
        }


        public void Withdraw(int amount)
        {
            //throw new NotImplementedException();
            if (Balance - amount < 500)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                this.Balance -= amount;
            }

        }
    }
}