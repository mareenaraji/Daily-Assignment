using System;
namespace SE9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, abs;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                abs = -n;
            else
                abs = n;           
            Console.WriteLine("Absolute valor is {0}", abs);
        }
    }
}
