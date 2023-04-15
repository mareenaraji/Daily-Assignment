using System;

namespace Absolute_difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number:");
            n=int.Parse( Console.ReadLine() );
            int result = Adifference(n);
            Console.WriteLine("absolute difference is:{0}",result);
            Console.ReadKey();

        }
        static int Adifference(int n)
        {
            if(n>51)
            {
                int res = (n - 51) * 3;
                return res;
            }
            else
            {
                int res1 = 51-n;
                return res1;
            }
        }
    }
}
