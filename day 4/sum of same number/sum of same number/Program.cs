using System;

namespace Absolute_difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter two number:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int result = SuM(n1 + n2);
            Console.WriteLine(" sum is:{0}", result);
            Console.ReadKey();

        }
        public static int SuM(int n1, int n2)
        {
            if (n1 == n2)
            {
                int res = result * 3;
                return res;
                Console.WriteLine("result is:" + res);

            }
        }
    }
}
}