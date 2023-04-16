using System;

namespace speeddisplay
{
    public class Program
    {
        static void Main(string[] args)
        {
            double d, t;
            Console.WriteLine("Enter the distance");
            d= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            t= double.Parse(Console.ReadLine());
            double result = speed(d, t);
            Console.WriteLine("Speed in km/hr is:" + result);
            double result1 = speed1(d, t);
            Console.WriteLine("Speed in mile/hr:" + result1);
            Console.ReadKey();

        }
        static double speed(double d,double t)
        {
            double s;
            s = d * t;
            return s;
        }
        static double speed1(double d,double t)
        {
            double s1;
            s1 = (d * t)*0.62;
            return s1;
        }

    }
}
