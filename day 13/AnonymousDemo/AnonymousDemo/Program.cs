using System;

namespace AnonymousDemo
{
    delegate void CountIT();
     class Program
    {
        static void Main()
        {
            CountIT count = delegate
            {
            for (int i=0; i<=10; i++)
                Console.WriteLine(i);
        };
        count();
        }
    }
}
