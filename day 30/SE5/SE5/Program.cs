using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, multipier;
            num = 2;
            do
            {
                multipier = 1;
                do
                {
                    Console.WriteLine("{0}*{1}={2}", num, multipier, num * multipier);
                    multipier++;
                }
                while (multipier <= 10);
                Console.WriteLine();
                num++;
            } while (num<= 6);
        }
    }
}
