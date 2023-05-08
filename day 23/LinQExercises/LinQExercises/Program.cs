using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] ar = { 1, 5, 2, 15, 19, 30, 21,22, 6, 4 };
        foreach (int n in ar)
            if (n % 2 == 0)
                Console.Write(n + " ");
        Console.WriteLine();
        var num = from n in ar
                  where n % 2 == 0
                  select n;
        foreach (int x in num)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}