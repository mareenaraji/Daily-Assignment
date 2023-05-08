using System;

namespace DeleggateDemo
{
    class Program
    {
        static void Add(int i,int j)
        {
            Console.WriteLine("Sum:" + (i + j));
        }
        static void Sub(int i,int j)
        {
            Console.WriteLine("Sub:" + (i - j));
        }
        public delegate void reftomethod(int i,int j);
        static void Main(string[] args)
        {
            // Add(10, 30);
            // reftomethod r1 = Add;
            // Sub(20, 10
            //  r2 = Sub;
            //r2.Invoke(10, 20)

            reftomethod multicast = Add;
            multicast += Sub;
            multicast(20, 10);
        }
    }
}
