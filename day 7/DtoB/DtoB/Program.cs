﻿using System;
namespace DtoB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            Console.WriteLine("enter the number:");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num = num / 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary :{0}", result);
        }
    }
}
