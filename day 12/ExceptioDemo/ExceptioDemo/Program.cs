using System;

namespace ExceptioDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0; int[] a = new int[5];
            try
            {
                int i = 10 / b;
                a[10] = 9;
               
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Out Of Bond");
            }
            finally
            {
                System.Console.WriteLine("Finally");

            }
            Console.WriteLine("Remaining Program");
        }
    }
}
