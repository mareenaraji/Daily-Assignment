using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 integer");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd integer");
            int j=int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("debugging ordeer");
        }
        public static void foo(int x,int y)
        {
            int t = 100;
            for (int i = x; i <=y;i++)
            {
                Console.WriteLine("India");

                t = t + 34;
            }
        }
    }
}
