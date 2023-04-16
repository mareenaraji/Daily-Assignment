using System;

namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("enter 'C' for circle or 'S' for square");
            string ch = Console.ReadLine();
            if (ch == "S")
                fig = new Square();
            else if (ch == "C")
            { fig = new Circle(); }

            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }

    }
    
}
