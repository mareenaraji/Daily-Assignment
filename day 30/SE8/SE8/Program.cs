﻿using System;
public class Product
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        int i = 0;

        while (i < n2)
        {
            result = result + n1;
            i++;
        }
        Console.WriteLine("{0} X {1} = {2}", n1, n2, result);
    }
}