using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface Food
    {
        string getType();
    }
    class Pizza : Food
    {
        public string getType()
        {
            return "Someone ordered FAst Food";
        }
    }
    class Cake : Food
    {
        public string getType()
        {
            return "Someone ordered Dessert";
        }
    }
    class FoodFactory
    {
        public Food GetFood(string order)
        {
            if (order.Equals("pizza"))
                return new Pizza();
            else if(order.Equals("cake"))
                return new Cake();
            else 
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FoodFactory factory = new FoodFactory();
            string order=Console.ReadLine().Trim();

            Food food= factory.GetFood(order);
            Console.WriteLine("The Factory returned class " +food.GetType().Name);
            Console.WriteLine(food.getType());
        }
    }
}
