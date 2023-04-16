using System;

namespace Interface
{
    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }
    class Circle: IFigure
     {
        private int Radius;
        public int Dimension
        {
            get { return Radius; }
            set { Radius = value; }
        }
        public double Area()
        {
            return Math.PI* Radius*Radius;
        }
        public double Perimeter()
        {
            return Math.PI * Radius;
        }
    }
    class Square : IFigure
    {
        private int Length;
        public int Dimension
        {
            get { return Length; }
            set { Length = value; }
        }
        public double Area()
        {
            return  Length * Length;
        }
        public double Perimeter()
        {
            return 4* Length;
        }
    }
}
