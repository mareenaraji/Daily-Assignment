﻿using System;
public class Exercise027
{
    public static void Main()
    {
        int number;
        int sum = 0;

        do
        {
            Console.Write("Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            sum = number + sum;

            if (number != 0)
                Console.WriteLine("Total: {0}", sum);
        }
        while (number != 0);

        Console.WriteLine("Finished");
    }
}