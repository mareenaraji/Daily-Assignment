using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = Clscalculator.AreEqual(21, 20);
            if(IsEqual)
            {
                Console.WriteLine("Both are equal");
            }
            else { Console.WriteLine("Both are not equal");
            }
        }
    }
}
