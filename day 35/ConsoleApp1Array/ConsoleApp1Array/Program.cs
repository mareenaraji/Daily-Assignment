using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            intArray = new int[5];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;

            Console.Write("for loop:");
            for(int i=0;i<intArray.Length; i++)
            {
                Console.Write(" "+intArray[i]);
            }
        }
    }
}
