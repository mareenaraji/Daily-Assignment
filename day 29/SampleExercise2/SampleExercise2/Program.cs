﻿using System;
public class Exercise025
{
    public static void Main()
    {
        int num, multiplier = 1;

        Console.Write("Insert a number to multiply: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (multiplier <= 10)
        {
            Console.WriteLine("{0} x {1} = {2}",
                num, multiplier, num * multiplier);
            multiplier++;
        }
    }
}