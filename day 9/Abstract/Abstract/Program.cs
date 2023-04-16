using System;

namespace Abstract
{
     class Program
    {
        static void Main(string[] args)
        {
            Figure fig=new Square();
            fig.Dimension = 90;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());

        }
    }
    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Square : Figure 
    {
        public override double Area() 
        {
            return Dimension * Dimension;
          
        }
        public override double Perimeter()
        {
            return 4 * Dimension;
        }
    
    }
    class Circle : Figure
    {
        public override double Area()
        {
            return Math.PI * Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 2*Math.PI * Dimension;
        }
    }
}
