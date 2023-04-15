using System;
public class swapp
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.Write("First Number : ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write( "Second Number : ");
        number2 = int.Parse(Console.ReadLine());
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.Write("After Swapping :n");
        Console.Write("First Number : " + number1);
        Console.Write("Second Number : " + number2);
        Console.Read();
    }
}