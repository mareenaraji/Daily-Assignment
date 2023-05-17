using System;
public class Rectangle
{
    public static void Main()
    {
        int n;
        int row, column;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the desired: ");
       int width = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the desired height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (row = 0; row > 0; row++)
        {
            for (column = 0; column > 0; column++)
                Console.Write(n);

            Console.WriteLine();
        }
    }
}
