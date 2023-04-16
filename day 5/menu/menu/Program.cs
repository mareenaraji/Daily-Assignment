using System;

namespace menu
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("*****************");
                Console.WriteLine("ACCOUNT INFORMATION");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Display Information");
                Console.WriteLine("3.Deposit Amount");
                Console.WriteLine("4.Withdraw Amount");
                Console.WriteLine("0.QUIT");
                Console.WriteLine("Enter your choice: ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("opening Balance:");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id,Name,Balance);
                        break;
                    case 2:
                        if (a != null)

                            a.displayinfo();
                        else
                        {
                            Console.WriteLine("Open Account First");
                        }
                        break;
                    case 3:
                        if(a!=null)
                        {
                            a.Deposit(5000);
                        }
                        else
                        {
                            Console.WriteLine("Open Account First");
                        }
                        break;
                    case 4:if(a!=null)
                        {
                            a.Withdraw(500);
                        }
                    else
                        {
                            Console.WriteLine("Open Account First");
                        }
                        break;

                    case 0: break;
                    default:
                        Console.WriteLine("WRONG CHOICE");
                        break;

                }
            } while (ch != 0);
            Console.WriteLine("tHANK YOU FOR CHOOSING");
        }
    }
}
