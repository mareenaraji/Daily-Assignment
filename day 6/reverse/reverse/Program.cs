﻿using System;

namespace reverse
{
     class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("\n\n Recursion:Get thereverse of a string :");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            str = StringReverse(str);
            Console.Write(" The reverse of the string is:);
            Console.Write(str) );
            Console.ReadKey();
            Console.Write("\n");
        }
        public static string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }
    }
}
