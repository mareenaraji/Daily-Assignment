using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountMinim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amount=int.Parse(Console.ReadLine());
            int w = amount / 2000;
            amount = amount % 2000;
            Console.WriteLine("no of 2000 notes: "+w);
            int x = amount / 500;
            amount = amount % 500;
            Console.WriteLine("no of 500 notes: " + x);
            int y = amount / 500;
            amount = amount % 500;
            Console.WriteLine("no of 200 notes: " + y);
            int z = amount / 200;
            amount = amount % 200;
            Console.WriteLine("no of 100 notes: " + z);
            int a = amount / 100;
            amount = amount % 100;
            Console.WriteLine("no of 50 notes: " + a);
            int b = amount / 50;
            amount = amount % 50;
            Console.WriteLine("no of 10 notes: " + b);
            int c= amount / 10;
            amount = amount % 10;
            Console.WriteLine("no of 5 notes: " + c);
            int d = amount / 5;
            amount = amount % 5;
            Console.WriteLine("no of 2 notes: " + d);
            int e = amount / 1;
            amount = amount % 1;
            Console.WriteLine("no of notes: " + e);
            Console.ReadKey();

        }
    }
}
