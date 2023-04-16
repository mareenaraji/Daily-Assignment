using System;

namespace Polymorphism
{
     class Shape
    {
        public virtual void DrawShape()
        {
            Console.WriteLine("Drawing shape");
        }
    }
    class Circle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class Rectangle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
