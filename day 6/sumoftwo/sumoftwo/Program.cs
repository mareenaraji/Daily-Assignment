using System;

namespace sumoftwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,sum;
            Console.WriteLine("enter first number:");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            num2=int.Parse(Console.ReadLine());
            sum = sumofnum(num1, num2);
            Console.WriteLine("Sum of two numbers is {0}", sum);

        }

        private static int sumofnum(int num1, int num2)
        {
            if(num1 == num2)
            {
                int ans = (num1 + num2) * 3;
                return ans;
            }
            else
            {
                int ans1 = (num1 + num2);
                return ans1;
            }

        
        }
    }
}
