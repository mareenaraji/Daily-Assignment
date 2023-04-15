using System;
public class Exercise6
{
    public static void Main()
    {
        int num1, num2, num3;

        Console.Write("first number to multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("second number to multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("third number to multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2 * num3;
        Console.WriteLine("Output: {0} x {1} x {2} = {3}",num1, num2, num3, result);
    }
}

