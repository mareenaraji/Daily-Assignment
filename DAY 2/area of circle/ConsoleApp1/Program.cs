using System;

     class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            double area;
            Console.WriteLine("ENTER RADIUS:");
            r = int.Parse(Console.ReadLine());
            area = ConsoleApp1(r);
            Console.WriteLine("Area of Circle having radius {0} is {1}", r, area);
        }
        static double ConsoleApp1(double r)
        {
            double area = 0.0;
            area = 3.14 * r * r;
            return area;

        }


    }

