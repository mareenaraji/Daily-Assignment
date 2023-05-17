using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;

            Console.Write("Enter a symbol: ");
            int symbol = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (row = 1; row <= height; row++)
            {
                for (column = 1; column <= width; column++)
                {
                    if ((row == 1) || (row == height))
                        Console.Write(symbol);
                    else
                    {
                        if ((column == 1) || (column == width))
                            Console.Write(symbol);
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
