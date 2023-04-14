using System;


namespace ConsoleApp2
{
     class Program
    {
        public static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter  age: ");
            age= Convert.ToInt32(Console.ReadLine());
            if (age > 18)
                Console.WriteLine("Eligible for voting");
            else
                Console.WriteLine("Not Eligible for voting");
        }
    }
}
