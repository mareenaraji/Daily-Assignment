﻿using System;

namespace ExceptionBank
{
    class bankexception:Exception
    {
        int acc;
        int bal;
        public bankexception(int a, int b)
        {
            acc = a;
            bal = b;
        }
        public void inform()
        {
            Console.WriteLine("Account Number: " + acc
         + " Balance left: " + bal);
        }
    }
}
