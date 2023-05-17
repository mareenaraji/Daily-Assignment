using System;
public class exercise041
{
    public static void Main()
    {
        int number;
        int digit = 0;

        Console.Write("Number? ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("(Warning: it is a negative number)");
            number = -number;
        }
        while (number > 0)
        {
            number = number / 10;
            digit++;
        }
        Console.WriteLine("{0} digits", digit);

    }
}