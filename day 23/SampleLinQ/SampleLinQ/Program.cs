﻿using System;
using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        int i = 101;

        bool result = i.IsGreaterThan(100);

        Console.WriteLine(result);
    }
}