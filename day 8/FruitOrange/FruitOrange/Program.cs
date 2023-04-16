using System;
using System.Linq;
using System.Linq.Expressions;

namespace FruitOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Orange orange=new Orange(1,"orange", "Telegana");
            Orange orange1 = new Orange(2, "Apple", "Maharashtra");
            orange.Display();
            orange1.Display();
        }

    }
    class Fruits
    {
        protected int num;
        public int Num
        {
            get { return num; }
            set
            {
                if (value > 0)
                {
                    num = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name=value; }
        }
        public Fruits()
        {

        }
        public Fruits(int num, string name)
        {
            Num = num;
            Name = name;
        }
    }
    class Orange:Fruits
    {
        private string _origin;
        private string[] places = { "himachal", "maharastra", "telegana" };
        public string Origin
        {
            get { return _origin; }
            set
            { 
                if (Array.BinarySearch(places, value >= 0)) 
                _origin = value;
            }
        }
        public Orange()
        {

        }
        public Orange(int num,string name,string origin):base(num,name)
        {
            _origin = origin;
        }
        public void Display()
        {
            Console.WriteLine($"The {num}st Fruit Name {name} is origined from {_origin}");
        }
    }
}
