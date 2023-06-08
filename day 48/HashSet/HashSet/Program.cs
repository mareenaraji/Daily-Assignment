using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniquePairs = new HashSet<string>();
            Console.Write("Enter the number of pairs: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the pairs separated by a space:");
            for (int i = 0; i < n; i++)
            {
                string pair = Console.ReadLine();
                uniquePairs.Add(pair);
                Console.WriteLine(uniquePairs.Count);
            }
        }
    }
}
